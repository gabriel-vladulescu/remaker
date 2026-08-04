# Lessons learned — Shadow of Death reconstruction

Distilled from the session that produced this project. Written for two audiences: future
work on *this* project, and future APK reverse-engineering/reconstruction projects in
general. Cross-reference: `C:\Users\user\Desktop\ApkExtraction.md` is the general-purpose
playbook this project's approach mostly followed (same AssetRipper + Il2CppDumper +
hand-reimplementation pipeline) — this file covers what that playbook doesn't, plus
project-specific specifics.

## The single highest-leverage technique: restore from open-source mirrors, don't reimplement

When a decompiled stub class matches a well-known **open-source library** — not the game's
own code, a third-party framework it depends on — the fastest and most correct path is
almost never "read the stub's field names and guess the logic." It's: identify the library,
find a matching (or close-version) open-source mirror on GitHub, and replace the stub
file(s) wholesale with the real source.

This project restored **four entire frameworks** this way:
- **Artemis ECS** (`thelinuxlich/artemis_CSharp`) — 51/53 files replaced wholesale
- **Spine 2D runtimes** (spine-runtimes, branch matched to the game's Spine version)
- **StrangeIoC** (the MVCS dependency-injection framework the whole game is built on)
- **NGUI** (100 files replaced from `jjhesk/unity-interview`'s bundled NGUI copy — this
  one turned out to be the actual blocker for *all* UI input in the game: `UICamera`,
  NGUI's entire touch/mouse event-dispatch hub, was silently 100% stub, meaning no button
  or joystick in the game could ever receive a click)

**Why this works and hand-reimplementation doesn't**: these libraries are stable,
widely-used, and largely version-independent for typical usage. A version mismatch
produces a handful of concrete compile errors (different property names, different base
method signatures) — cheap, mechanical fixes with a clear signal of exactly what's wrong.
Guessing gameplay-adjacent framework internals from field names alone produces *silent*
bugs instead: code that compiles and runs but behaves subtly wrong, with no error to point
at the problem. Ten minutes identifying "this is NGUI" and downloading a mirror beats hours
of hand-writing a plausible-looking touch-input system that's wrong in ways you won't
notice until much later.

**How to recognize the opportunity**: distinctive naming conventions
(`UICamera`/`NGUITools`/`UIWidget` → NGUI; `[Inject]`/`Signal<T>`/`Mediator` → StrangeIoC;
`Entity`/`EntityWorld`/`ComponentType` → an Entity-Component-System framework), copyright
headers surviving in decompiled comments, or just Googling a handful of unusual method/field
names together.

**What doesn't transfer this way**: the game's *own* code (everything under its own
namespace, e.g. `Assets.Scripts.Ssar.*` here) has no upstream to restore from — that's
genuinely hand-reimplementation territory, informed by field names, the IL2CPP dump's real
signatures, and (see below) Ghidra.

## Scene topology: verify the *actual* flow before building around an assumption

Early in this session, `LoadingScene` was wired between `EntryScene` and `TitleScene` — a
reasonable-looking guess. It was wrong: the real flow is `Entry → Title → (login) →
Loading → Main`, confirmed two ways after the fact — (1) `CheckAndLoadMainSceneCmd`'s
asset-preload list is entirely Main-scene concerns (main character model, daily-login
popup, equipment popup, skill-manager popup), nothing Title needs; (2) the user's own
description of the real game's actual boot sequence.

**Takeaway**: for scene/flow topology specifically, don't infer the graph from scene names
alone (`Entry`, `Loading`, `Title`, `Main` in *build settings order* is not necessarily
*navigation* order) — check what each scene's boot/transition command actually
preloads/depends on, or just ask/observe the real game once, before wiring transitions
between them. Retrofitting the correct order later is possible (this project did it) but
costs a full re-verification pass.

More generally: this project built gameplay systems (movement/combat/dungeon spawn)
*before* the boot chain (Entry/Loading/Title/Main). It worked out — everything above is
independent enough that retrofitting the shell around already-working gameplay caused no
real damage — but `ApkExtraction.md`'s Phase 2 ordering advice (shell first: loading → menu
→ UI, *then* gameplay) is the more efficient order and worth following from the start next
time. Building the shell first means every later gameplay addition happens inside a
navigable, testable game instead of a synthetic test harness.

## AssetRipper decompilation gotchas (recurring across this session)

- **"Mega-file" bug**: some source files bundle many classes internally
  (`Animation.cs`, `Atlas.cs`, `LeanTween.cs`, JSON libraries, `SevenZip/RangeCoder.cs`).
  Restoring from an open-source mirror where the upstream repo also has this pattern, or
  copying one multi-class file to multiple destination stub filenames, produces
  `CS0101` duplicate-definition errors. Fix: one destination file per class family, delete
  the rest.
- **Broken stub events**: AssetRipper emits
  `private event T name { [CompilerGenerated] add {} remove {} }` — empty accessors that
  *compile* but silently no-op every subscription. This is systemic, not a one-off — a
  project-wide regex sweep (107 fixes across 26 files here) is the right response the first
  time it's found, not a case-by-case fix.
- **Dummy shaders**: shaders AssetRipper couldn't decompile back to real HLSL get replaced
  with a placeholder whose fragment shader is hardcoded `return float4(1,1,1,1)` — solid
  white, ignoring every texture/light/property, marked with a `//DummyShaderTextExporter`
  comment. Search the whole project for this marker before assuming a rendering bug is
  something else (232 shaders were affected here, not a handful) — batch-remapping to a
  built-in shader is a fast, good-enough visual fix.
- **Field name ≠ GameObject name**: a `public GameObject btn_loginGuest` field has no
  necessary relationship to the actual GameObject's name in the scene hierarchy — they're
  independently settable in the Inspector. Don't `GameObject.Find("btn_loginGuest")`;
  find the owning component and read its field directly.
- **`Default-Material` fallback ≠ dummy shader**: a renderer with *no* material assigned
  at all (references Unity's built-in `Default-Material`, guid
  `0000000000000000f000000000000000`) looks similar to the dummy-shader white-screen bug
  but has a different cause and fix — the real material exists and is fine, something else
  (usually a runtime equip/cosmetic system) was supposed to assign it and doesn't yet.

## StrangeIoC gotchas

- This project's `commandBinder` is a `SignalCommandBinder`. It unconditionally casts its
  binding key to `IBaseSignal` in `ResolveBinding`/`Unbind` — binding a plain event value
  (`commandBinder.Bind(ContextEvent.START)`) **compiles fine but throws
  `InvalidCastException` at runtime**. Only `Signal`/`Signal<T>`-typed keys work with this
  binder; there is no runtime warning pointing at this, only a crash the first time the
  binding fires.
- The `Injector` **throws** (`InjectionException: Attempt to Instantiate a null binding`)
  for any `[Inject]` property with no matching binding — it does not silently inject
  `null`. Decompiled Commands/Mediators often have many `[Inject]` fields for systems that
  aren't reimplemented (shop signals, ad SDKs, achievement/quest systems); every one of
  those needs to be either bound or stripped, or the whole object fails to construct and
  silently blocks everything downstream of it.
- `Context.firstContext` is genuinely global/persistent for the app's lifetime as long as
  whatever created it is `DontDestroyOnLoad`'d (here: `GameInitController`, which carries
  the entire `GameInit.prefab` hierarchy — including the `EntryContext` — across every
  scene load). Views instantiated in *any* later scene that use the standard
  `View.Start()`/`OnEnable()` auto-registration pattern resolve their mediation against
  this one context, not something scene-local.

## Windows/Unity-batchmode-specific gotchas

- **Stale `Temp/UnityLockfile`** causes false-positive "another Unity instance is running"
  errors even when nothing is actually running, after any prior background/killed run.
  Always `Stop-Process -Name Unity -Force` + delete that lockfile before retrying a
  batchmode run that reports this.
- **Domain reload wipes editor-side static state.** Entering Play mode reloads the
  scripting domain — any `EditorApplication.update` subscription (or other static state)
  registered *before* entering Play mode is silently gone once Play mode actually starts.
  For automated multi-step Play-mode tests, use `UnityEditor.SessionState` (survives domain
  reload) as a flag checked by a `[RuntimeInitializeOnLoadMethod]` hook, which then spawns
  a real runtime `MonoBehaviour` — that one survives fine since it's created fresh, after
  the reload, in Play mode itself.
- **`UICamera.Notify(go, "OnClick", null)`** (NGUI's own event-dispatch entry point, a
  thin wrapper over `SendMessage`) is the correct way to simulate a real button click from
  an automated test — it exercises the actual dispatch path a real tap/click would, not a
  shortcut around it.
- **Ghidra project paths cannot contain a dot-prefixed path component** (e.g.
  `C:\.development\...` fails with `Path element starting with '.' is not permitted`,
  thrown from `ghidra.framework.model.ProjectLocator`). This only applies to the Ghidra
  **project** location (the first two `analyzeHeadless` arguments) — `-import`/
  `-scriptPath`/script-argument paths elsewhere are unaffected. Put the `.gpr`/`.rep`
  project somewhere without a leading-dot folder in its path.

## Ghidra: proven working setup (see `docs/ghidra-setup.md`)

Full auto-analysis + IL2CPP symbol labeling of `libil2cpp.so` is genuinely useful and not
that costly to set up once you have a working recipe (~30 min for this project's 61MB/
~192k-function binary, one-time). Don't skip it as "not needed yet" the way this project
initially did — the systems left as pure guesswork this session (dungeon/level generation,
exact tuning constants, combat formulas) are now decompilable to pseudo-C on demand instead
of hand-waved. See `docs/ghidra-setup.md` for the exact working commands/scripts for this
project, and `ApkExtraction.md` §6 for the general playbook (four failed approaches
documented there so they aren't repeated).
