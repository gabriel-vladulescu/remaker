# Shadow of Death — Reverse Engineering & Reconstruction Plan

**Goal:** Recover a working, editable source project for *Shadow of Death* by extracting
its original Unity assets and reimplementing its game logic in a fresh Unity project,
initially targeting **Android** (same platform as the source APK, easiest to validate
1:1 against the original). A Windows Standalone build is a near-zero-effort Unity
`Build Settings` change once the Android build is working, so it is **not** a separate
engineering track — it comes for free at the end.

**Scope note:** this is for personal interoperability / educational reverse engineering
of an APK we own a copy of. Nothing here is about redistributing the original assets,
IP, or a repackaged copy of someone else's binary — the target output is our own
reconstructed project.

---

## 1. Findings so far

| Fact | Value |
|---|---|
| Real game APK | `shadow-of-death.com.apk` (227 MB) |
| Decoy / wrong file | `ShadowofDeath.apk` (15 MB) — this is actually the **Uptodown app store client**, not the game. Ignore/delete. |
| Engine | Unity **2022.3.62f3**, IL2CPP scripting backend |
| Native libs of interest | `lib/arm64-v8a/libunity.so`, `lib/arm64-v8a/libil2cpp.so` (63 MB — contains all compiled C# game logic as native ARM64 code) |
| IL2CPP metadata | `assets/bin/Data/Managed/Metadata/global-metadata.dat` — valid magic `0xFAB11BAF`, version 31, **not encrypted/stripped** ⇒ full class/method/field name recovery is possible |
| Asset bundles | `assets/bin/Data/data.unity3d` + `datapack.unity3d` (standard `UnityFS` format) — extractable with AssetRipper/AssetStudio/UABEA |
| Java/dex layer | 12 `classes*.dex` files — confirmed almost entirely ad/analytics SDK glue (AppLovin, AppsFlyer, Firebase, Moloco, Pangle, Google Play Services). No game logic. |
| Studio / package | **Zonmob**, package `com.Zonmob.ShadowofDeath.FightingGames` |
| Extracted to | `c:/.development/extractor/shadow-of-death_extracted/` |
| Il2CppDumper output | `c:/.development/extractor/il2cpp_dump/` |
| AssetRipper exported project | `c:/.development/extractor/assetripper_project/ExportedProject/` |
| jadx decompiled dex output | `c:/.development/extractor/jadx_output/` |
| RE tools | `c:/.development/extractor/tools/` (apktool, jadx, Il2CppDumper, AssetRipper) |

**Why this game is a good RE candidate:** unencrypted metadata + standard IL2CPP/Unity
bundle format means no anti-tamper/packer layer to fight through first. The main cost is
labor (reimplementing logic), not unlocking access to the binary.

---

## 2. Chosen strategy: reconstruct, don't recompile

IL2CPP bakes C# into architecture-specific machine code — there is no tool that turns
`libil2cpp.so` back into a buildable Unity project automatically with full fidelity.
So instead of trying to "decompile the binary into a project," the plan is:

1. **Extract the real assets** (sprites, animations, audio, tilemaps/levels, prefabs,
   ScriptableObjects, UI) losslessly from the Unity asset bundles — this part IS
   basically 1:1 recoverable, no logic needed.
2. **Recover the code skeleton** (every class name, method signature, field name,
   string literal) from `global-metadata.dat` via Il2CppDumper — this tells us the
   exact shape of the original codebase (e.g. `PlayerController.TakeDamage(float)`,
   `SkillTree.Unlock(int)`) even though method bodies aren't included.
3. **Reimplement the logic by hand** in a new Unity 2022.3.x project, using the
   skeleton as a blueprint and the running APK (in an emulator) as the reference
   behavior to match.
4. **Fall back to Ghidra** only for specific systems where guessing from
   names/behavior isn't good enough (e.g. exact damage formulas, save-file format,
   RNG seeding) — targeted, not a full-binary decompile.

---

## 3. Tooling required

Currently installed: `unzip`, `python3`, `winget`. Missing: `java`, `apktool`, `jadx`,
Il2CppDumper, an asset extractor.

| Tool | Purpose | Install plan |
|---|---|---|
| JDK (Temurin 17+) | required by apktool/jadx | `winget install EclipseAdoptium.Temurin.17.JDK` |
| apktool | resource decoding (manifest, res/, smali) | download apktool.jar + wrapper, or `winget`/choco if available |
| jadx / jadx-gui | decompile the dex files (SDK glue confirmation) | download release zip from jadx GitHub releases |
| Il2CppDumper | dump `libil2cpp.so` + `global-metadata.dat` → class/method/field skeleton (as `.cs` stub + `dump.cs` + IDA/Ghidra script) | download release from Il2CppDumper GitHub |
| AssetRipper (preferred) or AssetStudio/UABEA | extract `data.unity3d`/`datapack.unity3d` into a near-buildable Unity project (textures, sprites, animation clips, audio, scenes, prefabs) | download release from AssetRipper GitHub |
| Unity Editor 2022.3.62f3 (via Unity Hub) | destination project — matching the original version avoids serialization mismatches | ✅ Installed at `C:\Program Files\Unity\Hub\Editor\2022.3.62f3\` with Android + Windows Standalone build support both present |
| Reference emulator | ground-truth reference to play the original game side-by-side while reimplementing | ✅ **BlueStacks** (not Android Studio AVD — its QEMU2 emulator hard-blocks arm64 system images on x86_64 hosts, no software fallback). Real APK installed and confirmed booting/rendering correctly on BlueStacks' 64-bit `Pie64` instance (Android 9, arm64-v8a translation). See §5 for the full setup story. |
| (Later, optional) Ghidra + Il2CppInspector Ghidra script | targeted disassembly of specific native functions | only if Phase 5 below is needed |

---

## 4. Phased plan

- [x] **Phase 0 — Recon.** Identify the real APK, confirm engine/version, confirm
      metadata is unencrypted. *(done)*
- [x] **Phase 1 — Tooling setup.** Installed JDK 17 (Temurin), apktool 3.0.3,
      jadx 1.5.6, Il2CppDumper 6.7.46, AssetRipper 1.3.14 into
      `c:/.development/extractor/tools/`. *(done)*
- [x] **Phase 2 — Asset extraction.** Loaded `shadow-of-death.com.apk` directly
      into AssetRipper (driven headless via its local REST API on port 41011)
      and exported to
      `c:/.development/extractor/assetripper_project/ExportedProject/`
      (1.4 GB). Recovered:
      - 7 real `.unity` scene files (`TitleScene`, `EntryScene`, `LoadingScene`,
        `SelectionScene`, `Main`, `Dungeon`, `DevScene`)
      - 4559 prefabs, 2282 materials, 2171 textures, 933 animation clips,
        77 Spine2D skeleton/atlas pairs (character animation), 519 wav + 19 ogg
        audio clips
      - 1308 `.asset` ScriptableObjects + 84 `.json` config files with **real
        game balance data** readable as-is (`AchievementConfig.json`,
        `ArenaConfig.json`, `AncientEquipmentConfig.json`,
        `AncientEnhancementConfig.json`, etc.)
      - 9117 `.cs` script stubs under `Assets/Scripts/Assembly-CSharp/`,
        already organized by original namespace/folder (signatures/fields
        only, no method bodies — same limitation as the Il2CppDumper output,
        expected for IL2CPP)
      - Identified third-party plugins in use: **BayatGames SaveGameFree**
        (save/load system), **NGUI** (UI), **I2 Localization**, **DentedPixel
        LeanTween**, **GameAnalyticsSDK**, **ProBuilder2**. Internal codename
        for the project appears to be "Ssar" (`Scripts/Ssar/Arena`,
        `Scripts/Ssar/Pet`, `Scripts/Ssar/DynamicAssets`). *(done)*
- [x] **Phase 3 — IL2CPP metadata dump.** Ran Il2CppDumper against
      `libil2cpp.so` + `global-metadata.dat` → output in
      `c:/.development/extractor/il2cpp_dump/` (`dump.cs` 27MB, `il2cpp.h` 62MB,
      `DummyDll/` stub assemblies incl. `Assembly-CSharp.dll` 9.4MB = the real
      game code). Symbols are **not obfuscated** — class names like
      `AIBuffComponent`, `AchievementLogic`, `HeroConfig`,
      `ActionTriggerConfig` are fully readable. This is the blueprint for
      Phase 6. *(done)*
- [x] **Phase 4 — Java/dex confirmation pass.** Ran jadx CLI (`jadx.cli.JadxCLI`
      — must invoke this class directly; running the plain `-all.jar` launches
      the GUI instead) over all 12 dex files → 49,694 Java files in
      `c:/.development/extractor/jadx_output/` (99% success, 455 minor
      per-class errors out of 33,011, normal for a project this size).
      Confirmed the hypothesis: the game's own package
      `com.Zonmob.ShadowofDeath.FightingGames` (studio = **Zonmob**) contains
      only auto-generated `BuildConfig.java`/`R.java` — zero game logic. Only
      other custom Java: `com/ssar/auth/GoogleSignInBridgeActivity.java`
      (Google Sign-In bridge) and `com/hippogames/simpleandroidnotifications`
      (3rd-party local notifications plugin). Everything else confirmed as
      ad/analytics SDK glue. All real game logic is confirmed to live in
      IL2CPP only — no further use for the dex output going forward.
      *(done)*
- [x] **Phase 5 — New Unity project scaffold.** No separate scaffold needed —
      AssetRipper's export at `assetripper_project/ExportedProject/` is
      already a complete, valid Unity project (`ProjectVersion.txt` matches
      2022.3.62f3 exactly, `Packages/manifest.json` present). Ran a headless
      batchmode import/compile pass
      (`Unity.exe -batchmode -nographics -projectPath ... -quit`).
      First pass: **only 5 distinct compile errors** across all 9117 script
      files, all the same mechanical cause — derived-class constructors not
      forwarding to a required base constructor (harmless artifact of
      AssetRipper's stub reconstruction; every method/constructor body is an
      empty `{ }` stub since IL2CPP strips bodies to native code — no logic
      was lost by this fix). Fixed all 5 sites:
      - `MirrorEffectView.cs` — 3 nested config classes needed
        `: base(iconQuestion)`
      - `Character2Skill8.cs` — `VfxFollowTarget2` needed
        `: base(target, vfx, vfxOffset, maxSpeed, maxAcceleration)`
      - `Monster2000001Skill8.cs` — `BloodLinkChaser` needed
        `: base(pathInterval, isRecordPath)`

      Rebuilt clean: **0 compile errors, 0 asset import failures**, full
      1.4GB asset set imported successfully. Confirms the AssetRipper
      reconstruction is very high fidelity for this project. *(done)*
- [~] **Phase 6 — Logic reimplementation.** *(in progress)*

      **Strategy pivot (big win):** before manually reimplementing anything,
      check whether a stub file's namespace is a known **public open-source
      library** rather than proprietary game code — Unity's
      `Assembly-CSharp-firstpass` (third-party plugin assembly) is full of
      these. Where the real source is findable, drop it in wholesale instead
      of reverse-engineering empty method stubs by hand. Confirmed so far:
      - [x] **Artemis** (`Assets/Plugins/Assembly-CSharp-firstpass/Artemis/`)
            — the whole ECS framework HeroStateMachine/MovementComponent/etc.
            are built on. Public, BSD-2-clause:
            [thelinuxlich/artemis_CSharp](https://github.com/thelinuxlich/artemis_CSharp).
            Cloned to `tools/artemis_csharp_upstream/`, 51 of 53 files are a
            byte-for-byte version match and were copied straight over the
            stubs; the 2 game-specific extension files
            (`EntitySystemWithTime.cs`, `EntityProcessingSystemWithTime.cs`)
            were hand-implemented by pattern-matching the real base classes
            (trivial — just wire `EntityWorld.Delta` ticks into a float
            seconds param).
      - [x] **Full plugin restoration pass completed** — went further than
            planned since each restoration kept surfacing more. Final state:
            - **Spine** — full runtime restored from
              `spine-runtimes` branch `3.7` (spine-csharp + spine-unity).
              This was the deepest rabbit hole: `Animation.cs`, `Atlas.cs`,
              and `SpineAttributes.cs` are upstream "mega files" bundling
              ~10-20 classes each internally, while the game's original stub
              set has those same classes split into separate per-class
              files — copying both created ~50 duplicate-definition errors.
              Resolved by deleting every superseded small stub file in favor
              of the mega file's nested version. A few companion files
              (`AtlasAssetBase.cs`, `SkeletonDataModifierAsset.cs`, etc.)
              didn't exist in the stub set at all and were added fresh.
              `SpineMesh.cs` turned out to be a genuinely incompatible
              legacy variant conflicting with the dedicated
              `MeshGenerator.cs`/`SkeletonRenderer.cs` files the game
              actually uses — deleted it and hand-wrote minimal stubs for
              the 4 small companion types it displaced
              (`MeshRendererBuffers`, `SubmeshInstruction`,
              `MeshGeneratorDelegate`, plus extending `MeshGenerator.cs`
              with 3 missing members). Unused `SkeletonGraphic.cs` (UI
              variant, zero references from game code) and unused
              `SimpleFileBrowser` (zero references, newer version needed
              missing TMPro/UISkin types) were deleted outright rather than
              chased.
            - **strange** (StrangeIoC) — 114/121 files restored from
              [strangeioc/strangeioc](https://github.com/strangeioc/strangeioc).
              Needed one deviation: the game's fork adds
              `protected virtual void Awake()` to `ContextView.cs` (upstream
              only has it in a doc comment) since game code overrides it.
            - **LeanTween** — restored from
              [dentedpixel/LeanTween](https://github.com/dentedpixel/LeanTween).
              Single mega-file (`LeanTween.cs`) bundling `LTBezier`,
              `LTRect`, `LTSpline`, etc. — same duplicate-resolution pattern
              as Spine. One real API mismatch: the game's `LTDescr.cs` stub
              requires `updateInternal(float deltaTime)` but the GitHub
              fork's `LeanTween.cs` calls the parameterless form — patched
              both call sites to pass `Time.deltaTime`.
            - **SevenZip/LZMA** — restored from
              [jljusten/LZMA-SDK](https://github.com/jljusten/LZMA-SDK)
              (`CS/7zip`). Newer SDK snapshots split what the game's stub
              set has as single files (`BinTree.cs`, `Encoder.cs`, etc.)
              into per-purpose-prefixed files (`LzBinTree.cs`,
              `RangeCoder.cs` containing both Encoder+Decoder, etc.) —
              mapped by matching class name, not filename. Caused a
              self-inflicted "fan-out" bug: copying one multi-class source
              file to *multiple* same-named-differently stub destinations
              duplicated every class in each destination — had to delete
              the redundant copies (kept one file per class family).
            - **MiniJSON**, **SimpleJSON**, **SharpJson** — fully restored,
              single-file libraries, consolidated to match. (Spine bundles
              its own internal copy of SharpJson too — historical, they
              share code — so the standalone SharpJson copy was dropped in
              favor of Spine's.)
            - **SimpleDiskUtils** — fully restored from
              [dkrprasetya/simple-disk-utils](https://github.com/dkrprasetya/simple-disk-utils)
              (matches the `com.dikra.diskutils` Java package seen in the
              jadx output earlier).
            - **LitJson** — only 9/29 files restored; the game bundles an
              extended fork (attribute-based serialization, `JsonInclude`/
              `JsonIgnore`/etc.) that doesn't match the standard GitHub
              mirror. Left as a mix of real+stub rather than risk a broken
              merge.
            - **BayatGames SaveGameFree** — left as stub. Current upstream
              renamed its namespace (`Bayat.Unity.SaveGameFree` vs the
              game's `BayatGames.SaveGameFree`) and likely has an evolved
              API surface; needs an older tagged release to restore safely,
              not attempted.
            - Not attempted at all (lower priority, revisit opportunistically):
              `CodeStage` (AntiCheat Toolkit), `DG` (DOTween), `I2`
              Localization, `Com`/ProCamera2D, `MirzaBeig`,
              `PigeonCoopToolkit`, `MagicalFX`, `Xft`, `GameAnalyticsSDK`
              (likely to be *removed* rather than restored, see Phase 6 note
              on monetization systems below).
            - **End result: 0 compile errors**, verified via full headless
              rebuild.
      - [ ] The genuinely proprietary surface — where real reimplementation
            work is unavoidable — is under `SSAR/`, `Scripts/Ssar/`, and
            `core/` (Zonmob's own code: combat, skills, AI, dungeon,
            progression, etc.) plus the two Artemis extension files above.

      **Real-runtime findings while restoring Artemis:** modern Unity
      (2022.3, .NET 4.x-equivalent scripting runtime) natively has
      `System.Numerics.BigInteger` — the original 2015-era Unity5 port of
      Artemis needed `MathNet.Numerics.BigInteger` as a substitute because
      Unity's Mono runtime didn't have it back then. Repointed the `#if
      UNITY5` branches in `Aspect.cs`/`EntityManager.cs` from
      `MathNet.Numerics` to `global::System.Numerics` (avoids pulling in an
      extra dependency) — and had to add the *same* `#if UNITY5 using
      global::System.Numerics; #endif` block to `ComponentType.cs`,
      `Entity.cs`, `ComponentTypeManager.cs`, `SystemBitManager.cs`, and
      `EntitySystem.cs` too, since upstream's `UNITY5` guard only excluded
      the non-Unity `System.Numerics` import in those files without ever
      providing a replacement — a latent bug in the upstream port that
      happened to not matter on real old-Unity/MathNet setups. All 7 patched
      files are the *only* intentional deviations from pristine upstream
      Artemis source; `SystemManager.cs` needed a temporary unblocking patch
      mid-process but was restored to a byte-for-byte match with upstream
      once the `UNITY5` define was set project-wide (`ProjectSettings.asset`
      → `scriptingDefineSymbols: {Android: UNITY5, Standalone: UNITY5}`).

      **Player movement/controller vertical slice — implemented, compiles clean:**
      - [x] `Core/FiniteStateMachine/StateMachine.cs` + `State.cs` — the
            generic, game-agnostic FSM engine everything sits on: table-driven
            legal transitions (`DefineTransition`), history stack
            (`GoBackToPreviousState`), pre/post transition listeners.
      - [x] `MovementComponent` (Artemis `IComponent`) — real physics state:
            `RunData`/`JumpData`/`DashData` (`SetData` + real
            `JumpData.GetGravityJump()`/`GetGravityFallGround()` via
            kinematics `g = 2h/t²`), run-speed/velocity modifier stacking,
            `AccessLevel` gating (int-per-level counter, `RecalculateMinimumAccessLevel`
            picks the highest active lock), its own internal `IState`
            pattern (`OnGroundState`/`JumpFallState`/`DashState`, distinct
            from the FSM's `State`) via `SetState(MoveState)`.
      - [x] `MovementSystem : EntityProcessingSystemWithTime` — the Artemis
            per-frame tick: `ApplyGravity` → `Move` (applies `velocity * dt`
            to the entity's transform via `CharacterMediatorComponent`) →
            `CheckGround` (ground/air `MoveState` transitions) →
            `ProcessMovingRequestQueue` (dequeues `AbsRequest`s, gates them
            by `AccessLevel`, calls `Update`/`Expired`/`Exit`).
      - [x] `CharacterMove : Movement` — the state-machine-facing bridge
            (`Run`/`Dash`/`Jump`/`ForceStop`/`DisplaceBy`) wrapping the real
            `MovementComponent`.
      - [x] `CharacterInput : UserInput` — command-buffer pattern
            (`Run(AbsRequest, autoRelease)`/`Dash`/`Jump`/`Attack` set
            request objects + bool flags; `IsInputRun()` etc. just read them
            back). NGUI joystick → `CharacterInput` wiring
            (`UserButtonInputLayout`/`JoyStick`) is **not yet done** — see
            open items below.
      - [x] `RunRequest : AbsRequest` — `Update` sets
            `movement.velocity.x = (float)dir * movement.RunSpeed()` each
            tick (so live speed modifiers apply); `Exit` zeroes it.
      - [x] `SpawnState`/`IdleState`/`RunState` (the actual `Core.FiniteStateMachine.State`
            implementations) + base `HeroStateMachine` wiring
            (`DefineStates`/`DefineTransitions` for `Spawn → Idle ⇄ Run`,
            plus legal-but-unimplemented edges to `Dash`/`JumpFall`/`ComboAttack1`
            that will throw if actually triggered right now — expected, not
            a bug).
      - [x] `CharacterAnimation : Animation` (930 lines, the concrete class
            `MainCharacterTemplate` actually wires up — confirmed via its
            `private CharacterAnimation ca;` field) — implemented
            `PlaySpawn`/`PlayIdle`/`PlayRun` + the spawn-end event plumbing.
            **Real, decompiled-accurate constants used directly**, e.g.
            `spawn_duration = 1.2f` (these are `const float` literals baked
            into IL2CPP metadata, not guesses). Uses legacy `UnityEngine.Animation.Play(clipName)`
            — clip names ("Spawn"/"Idle"/"Run") are a **best-effort guess**,
            safe no-op if wrong (`Animation.Play` doesn't throw on a missing
            clip); state-transition *timing* is correct regardless since
            it's driven by the real constants via a coroutine
            (`WaitThenNotify`), not by the animation actually finishing.
            Open question not yet resolved: this game also has extensive
            Spine skeletons — unclear whether `CharacterAnimation`'s
            `UnityEngine.Animation` is the real primary visual driver or a
            secondary/legacy path; needs visual confirmation once the
            project can actually be opened and played.
      - [x] `CharacterEvent : Event` + `CharacterEventComponent` — plain
            C# event add/remove/notify plumbing.
      - [x] **Significant side-fix**: found and swept a systemic
            AssetRipper decompilation artifact — private events reconstructed
            as `private event T name { [CompilerGenerated] add {} remove {} }`
            with **empty accessor bodies**. This compiles fine but silently
            no-ops every `+=`/`-=`/invoke on that event — a correctness trap
            that would have caused quiet, hard-to-diagnose "my listener never
            fires" bugs anywhere this pattern occurs, not just in movement
            code. Ran a project-wide regex sweep
            (`private|public|protected|internal event T name { [CompilerGenerated] add{} remove{} }`
            → `... event T name;`) — **fixed 107 occurrences across 26
            files**. Worth re-running this sweep after any future large
            batch of stub restoration, since new instances of the same
            pattern will keep surfacing as more of the codebase is filled in.
      - [x] Real per-character tuning values confirmed from prefab YAML
            (`Assets/Resources/characters/group_1/1/1_1_Prefab.prefab`,
            `MovementConfigData` MonoBehaviour): `moveSpeed: 4`,
            `jumpHeight: 2.4`, `jumpDurationMaxHeight: 0.31`,
            `dashDistance: 6.5`, `dashDuration: 0.55`, etc. — these feed
            `MovementComponent.InitWithConfig` automatically once the entity
            is actually spawned from that prefab, no manual wiring needed.
      - [~] **Known simplification**: `CharacterMediatorComponent` (bridges
            `MovementComponent`'s abstract velocity to actual GameObject
            transform movement) uses direct `Transform.position` + a simple
            downward `Physics.Raycast` for `IsGrounded`, **not** the real
            `SuperCharacterController` capsule-raycast system the game
            actually uses (`SSAR.BattleSystem.Movement.SuperCharacterController`,
            a heavily-customized wrapper around the open-source
            [IronWarrior/SuperCharacterController](https://github.com/IronWarrior/SuperCharacterController)
            we restored `SuperCollider`/`SuperCollisionType`/`SuperMath`/`SuperStateMachine`
            from — but `SuperCollider.cs` itself had to be deleted, its
            `BSPTree.ClosestPointOnTriangleToPoint` call didn't match this
            game's customized `BSPTree.cs` accessibility). Good enough for
            flat-ground walk/idle testing; will need real capsule-collision
            handling before slopes/stairs/ledges work correctly.

      **Real entity spawn orchestration — deliberately deferred, not
      implemented.** Traced the real chain fully:
      `BaseEntityTemplate.BuildEntity`/`OnBuild`/`FinishSetupBase`,
      `MainCharacterTemplate.OnBuild`/`FinishSetupBase`/`GetHeroStateMachine`
      is where `MovementComponent`, `CharacterMediatorComponent`,
      `CharacterInput`, `CharacterJump`, `CharacterMove`, `CharacterAnimation`,
      `HeroStateMachine` would get `new`'d and attached onto a real `Entity`
      — but `MainCharacterTemplate` (271 lines) turns out to be entangled
      with a large amount of *content* machinery that's unrelated to
      movement itself: weapon-skin swapping (`Character3Skill8Swap`),
      ancient-item skill config loading, weapon passive skill JSON mapping,
      particle/renderer discovery for material overrides. Above that,
      `InitDungeonSystemCmd` (the StrangeIoC command that actually
      bootstraps the `EntityWorld` in a real scene) pulls in monster
      spawning, camera bounds, achievements, and daily quests — the whole
      game loop, not just movement. Properly reimplementing that whole
      chain is a separate, large undertaking on its own and was judged not
      worth doing before the movement code itself had ever been exercised
      even once.

      **Instead: built a standalone validation harness.**
      `Assets/Scripts/_PhaseValidation/MovementValidationHarness.cs` (new
      file, clearly separated from the reconstructed game code, not part of
      the original game). A single `MonoBehaviour` that: spins up its own
      `EntityWorld`, registers `MovementSystem`, spawns a plain capsule
      primitive (not the real Spine-rigged prefab — sidesteps prefab
      loading entirely), builds a `MovementConfigData` with the real known
      group_1 values (`moveSpeed: 4`, `jumpHeight: 2.4`, etc.), constructs
      one `Entity` with `MovementComponent` + `CharacterMediatorComponent`
      + `CharacterEventComponent`, then builds `CharacterInput` →
      `CharacterMove` → `CharacterJump` → `CharacterAnimation` →
      `HeroStateMachine` exactly like the real template would, and feeds
      arrow-key input directly into `CharacterInput.Run(...)` each frame
      (bypassing the not-yet-wired NGUI joystick). Also includes a minimal
      `DummyCharacter : Character` (the abstract combat-system base class)
      since the constructor needs *some* instance but nothing in the
      current Idle/Run logic actually calls its ~30 combat-related abstract
      methods, and a `SimpleRoutineRunner : RoutineRunner` so
      `CharacterAnimation`'s coroutine-based timing has something to run on.
      **Compiles clean (0 errors) AND has actually been run and validated.**
      Turns out Unity's `-batchmode -nographics` *does* tick `Update()` even
      without a real display — discovered this and used it to automate a
      real smoke test rather than waiting for an interactive session:
      `Assets/Editor/SetupValidationScene.cs` (builds a scratch scene with a
      ground plane + the harness, `-executeMethod SetupValidationScene.Run`)
      and `Assets/Editor/SmokeTestValidation.cs` (opens that scene, flips
      `EditorApplication.isPlaying = true`, no `-quit` so the process stays
      alive in Play mode while we tail the log).
      - First run **caught a real bug**: `CharacterMediatorComponent.InitValues`
        called `_prefab.GetComponent<SuperCharacterController>()`, but
        `SuperCharacterController` here is a plain C# class, not a
        `MonoBehaviour`/`Component` — throws `ArgumentException` immediately,
        silently aborting the rest of `Start()` (so `characterInput`,
        `heroStateMachine` etc. never got assigned), which then surfaced
        downstream as a `NullReferenceException` in `Update()`. Fixed by
        just removing that line (dead code — our simplified
        `CharacterMediatorComponent` never used the field it set).
      - After the fix: reran with a `heroStateMachine.ListenToStateTransition`
        logger added. Result: **`Spawn -> Idle` fires correctly** after the
        real 1.2s `spawn_duration`, with zero exceptions throughout. This
        confirms the whole chain genuinely works end-to-end — coroutine-based
        animation timing (`WaitThenNotify` → `SpawnAnimationEnd` event) →
        `SpawnState.Execute` detecting it → `StateMachine.ChangeStateWithHistory`
        → `IdleState.Enter` calling `PlayIdle()`/`ForceStop()` — not just
        "doesn't crash on startup."
      - **Not yet exercised this way**: actual `Run` state entry (needs real
        keyboard input, which this automated approach can't fake — arrow
        keys read via `Input.GetAxisRaw` require an interactive session) and
        anything visual (batchmode has no rendering). That's what's left for
        you to check interactively — open
        `Assets/Scenes/_PhaseValidation/MovementValidation.unity` and press
        Play.

      **Update: the real entity spawn orchestration is now implemented too**
      (scoped to movement — weapon-skin/ancient-item/skill-VFX logic
      deliberately left stubbed, that's Combat/Skills phase work):
      - [x] `BaseHeroTemplateArgs` constructors, `EntityTemplateManager`
            (thin dispatch to `EntityWorld.CreateEntityFromTemplate`),
            `BaseEntityTemplate.BuildEntity`/`GetCharacterInput`/`CreateAnimationController`
            (`MaxJumpCharge` changed `private`→`protected` so
            `MainCharacterTemplate` can call it — the only accessibility
            deviation from upstream signatures in this pass).
      - [x] **`DefaultSkillCharacter : Character`** — this turned out to
            already exist as the real concrete implementation (245 lines,
            constructor takes exactly `MovementComponent`/`CharacterMediatorComponent`/
            `CharacterInput`/`CharacterJump`/etc., all things already built)
            rather than needing a new one invented. Implemented all ~30
            abstract members as thin passes to the already-real
            `MovementComponent`/`CharacterMediatorComponent`/`CharacterAnimation`.
            `Dash(...)`/`Jump(...)` (the richer skill-triggered-parameter
            overloads, distinct from `CharacterMove`'s simpler default-dash
            entry point) compute velocity directly from the passed
            distance/duration/height rather than from `MovementComponent`'s
            own config data — reasonable, not yet verified against real
            skill-cast behavior.
      - [x] `MainCharacterTemplate.OnBuild` — assembles
            `MovementComponent`/`CharacterMediatorComponent`/`CharacterEventComponent`/
            `CharacterInput`/`CharacterMove`/`CharacterJump`/`CharacterAnimation`/
            `HeroStateMachine` onto a real `Entity`, reading
            `SimpleMovementConfigData` straight off the spawned prefab
            (`baseHeroTemplateArgs.instance`) instead of hand-building one
            like the validation harness does.
      - [x] `MainCharacterTemplate.GetHeroStateMachine`/`HeroStateMachineType` —
            picks `Character2StateMachine`/`3`/`4` by `groupId`, defaults to
            base `HeroStateMachine` (group 1, the character we have real
            prefab data for). The groupId→subclass mapping is inferred from
            naming convention, not confirmed against real dispatch logic.
      - [x] `CharacterRenderer`/`FindRendererComponents`/`FindParticleSystems` —
            real `GetComponentsInChildren` + enable/disable, `Play()`/`Stop()`.
      - [x] **New infrastructure not in the original game**:
            `HeroStateMachineComponent`/`HeroStateMachineSystem` — a small
            Artemis Component+System pair (mirroring the existing
            `MovementComponent`/`MovementSystem` pattern exactly) so
            something ticks `HeroStateMachine.Update()` every frame once
            attached to a real entity. No such wrapper exists anywhere in
            the decompiled codebase, so this had to be added rather than
            recovered. Also implemented `RoutineRunnerSubSystem` for real
            (was a stub) — it's a plain C# class implementing the
            `RoutineRunner` interface, so it needs an internal hidden
            `MonoBehaviour` host to actually call `StartCoroutine` on;
            added one (`Host : MonoBehaviour`, private nested class,
            `DontDestroyOnLoad`).
      - Compiles clean (0 errors), confirmed via headless rebuild.
      - **Not yet done**: nothing actually *calls* this chain yet in a real
        scene. `SpawnMainCharacterCmd`/`InitDungeonSystemCmd` (the StrangeIoC
        commands that would construct `BaseHeroTemplateArgs` with real prefab
        data and invoke `EntityTemplateManager.CreateMainCharacter`) are
        still stubs — that's the next piece if the goal is "works in the
        actual Dungeon scene" rather than "the template classes are ready
        to be called correctly." `MainCharacterTemplate` isn't registered
        with an `EntityWorld` anywhere outside of the (unrelated)
        `MovementValidationHarness`.

      **Update: built and validated a second harness using the REAL spawn
      chain.** `Assets/Scripts/_PhaseValidation/RealCharacterValidationHarness.cs`
      + `Assets/Editor/SetupRealCharacterValidationScene.cs` — same idea as
      the capsule harness, but loads the actual Spine-rigged prefab
      (`Resources.Load<GameObject>("characters/group_1/1/1_1_Prefab")`) and
      spawns it through `EntityTemplateManager.CreateMainCharacter` →
      `MainCharacterTemplate.OnBuild`/`GetHeroStateMachine`, i.e. the real
      production code path, not hand-built components. Scene saved at
      `Assets/Scenes/_PhaseValidation/RealCharacterValidation.unity`.
      Two more real bugs found and fixed via the same automated
      batchmode-Play-mode smoke test approach:
      - `MainCharacterTemplate.cs` was missing several `using` statements
        (`CharacterEvent`/`CharacterEventComponent`, `RoutineRunnerSubSystem`,
        `Character`) and called two `BaseEntityTemplate` methods
        (`CreateAnimationController`, already had `MaxJumpCharge`) that were
        still `private` — changed both to `protected`. (Note: an earlier
        compile-check in this session reported 0 errors for this exact
        broken state — turned out to be a stale/misleading result, root
        cause not fully pinned down, possibly a leftover locked Unity
        process from a prior smoke test silently competing for the project;
        worth double-checking compile results stay fresh if this happens
        again, e.g. via log timestamp vs. wall clock.)
      - `MissingEntityTemplateException: EntityTemplate for the tag
        MainChracter was not registered` — `EntityWorld.InitializeAll(false)`
        deliberately skips Artemis's `[ArtemisEntityTemplate]` reflection
        scanning (passing `true` would've also auto-discovered and tried to
        instantiate every *other* `[ArtemisEntitySystem]`/`[ArtemisEntityTemplate]`-tagged
        class across the whole codebase, most still unfinished stubs — too
        risky). Fixed by registering `MainCharacterTemplate` explicitly:
        `entityWorld.SetEntityTemplate("MainChracter", new MainCharacterTemplate())`.
      - **Result after fixes: clean spawn, zero exceptions, and — confirmed
        via the actual stack trace, not a simplified test loop —
        `EntityWorld.Update` → `SystemManager` → `HeroStateMachineSystem.Process`
        → `HeroStateMachine.Update` → `SpawnState.Execute` → `Spawn -> Idle`
        fires correctly.** This is the real ECS tick chain working
        end-to-end with the real prefab, not a mocked substitute.

      **This is a genuine "can run and test the game" checkpoint** for the
      movement system specifically: open
      `Assets/Scenes/_PhaseValidation/RealCharacterValidation.unity`, press
      Play, arrow keys move the real character. Visual correctness (does
      the Spine character actually animate, does it look right) hasn't been
      confirmed by either of us yet — batchmode has no rendering, so that
      needs a real interactive session.

      **Update from your first interactive test**: real character spawns
      with visible sword/model, Run animation and state transitions work —
      confirms the whole pipeline is visually real, not just log-correct.
      Found and fixed a real bug: character always moved right regardless
      of input direction. Root cause: `CharacterMove.Run()` read
      `MovementComponent.Direction` to decide which way to move, but nothing
      ever updated that field from actual input — it just stayed at its
      initial `Direction.Right` forever. Fixed by having `CharacterMove.Run()`
      read the direction from `CharacterInput.RunRequest` (which the
      harness's input-handling code already set correctly) instead, and
      pass `changeFaceDirection: true` so `MovementComponent.Direction`
      actually updates now.

      Also implemented `DashState`/`JumpFallState` (both were still stubs)
      so Dash/Jump are testable, not just Idle/Run:
      - `JumpFallState` — calls `movement.Jump()` + `hero.ConsumeJumpCharge()`
        on enter, listens to `Event.ListenToFallEnd` (already-wired plumbing
        from `MovementSystem.CheckGround` → `CharacterEventComponent.NotifyExitfall`)
        to know when it's landed, then transitions back to Run/Idle.
      - `DashState` — calls `movement.Dash()` on enter, listens to
        `Event.ListenToDashEnd`. Needed genuinely new wiring for this to
        work: `CharacterMove.Dash()` previously only switched `MoveState`
        without ever setting velocity (dead code); fixed it to compute
        speed from `dashData.DashDistance/DashDuration`. Also added
        `MovementComponent.dashElapsedTime` and a
        `MovementSystem.CheckDashEnd` check (mirrors the existing
        `CheckGround` pattern) to actually fire `NotifyExitDash` when the
        real dash duration elapses — this side of the event wiring didn't
        exist anywhere yet.
      - Bound `Space` (Jump) and `Left Shift` (Dash) in both harnesses,
        using a one-shot key-down → consume-this-frame → auto-release
        pattern so they don't re-trigger every frame while held.
      - Combo-attack transitions are still legal in the transition table
        but `ComboAttack1State` etc. remain unimplemented stubs — no attack
        key is bound in the harness on purpose, to avoid hitting an
        unimplemented-state exception.
      - Compiles clean; automated batchmode smoke test confirms no
        regressions (Spawn→Idle still fires correctly), but **actual
        direction/Dash/Jump correctness needs your interactive test** —
        batch mode can't simulate real keyboard input, so this is
        unverified until you try it.

      **Still open:**
      - [x] Interactive test of the direction fix + Dash (Left Shift) +
            Jump (Space) — confirmed working by you in the Editor (direction
            bug fixed; sword-wielding Spine character spawns, runs, animates).
      - [x] Wire `InitDungeonSystemCmd` so this works from the *actual*
            Dungeon scene, not just a purpose-built validation scene — see
            "Real Dungeon scene boot" update below.
      - [x] NGUI input wiring: `JoyStick.OnDrag`/`UserButtonInputLayout.Run/Jump/Dash/Attack`
            → `CharacterInput` calls — see "Real Dungeon scene boot" update
            below.
      - [ ] Dash/Jump/ComboAttack states (legal transitions are defined,
            state classes themselves still stub).

      **Update: NGUI restored from open source + real Dungeon scene now boots.**
      Following your "go full rampage" instruction, investigated wiring the
      NGUI joystick/buttons and discovered the problem was much bigger than
      expected: `UICamera` (NGUI's entire touch/mouse detection and event
      dispatch hub — the thing that calls `OnPress`/`OnDrag`/`OnClick` on
      every UI element in the game) was completely stub, not just `JoyStick`.
      That meant *no* UI in the game — buttons, joystick, menus — could ever
      receive input, regardless of how well `JoyStick`/`UserButtonInputLayout`
      themselves were implemented.
      - [x] **Restored the entire NGUI plugin from open source** (same
            "wholesale file replacement" strategy as Artemis/Spine earlier):
            pulled a full NGUI 3.x source tree from
            github.com/jjhesk/unity-interview (101 files across
            Interaction/Internal/Tweening/UI) and replaced every matching
            stub filename in `Assets/Scripts/Assembly-CSharp/` (100 files —
            `UICamera`, `UIWidget`, `UIPanel`, `UIButton`, `UIDragObject`,
            `NGUITools`, etc.). Confirmed via `[DoNotObfuscateNGUI]` attribute
            markers that the pre-restoration stubs were genuine decompiled
            signatures from this exact build, not placeholders.
      - [x] Fixed version-mismatch fallout from the mirror being a slightly
            newer NGUI than the game shipped:
            - `UIWrapContent` was missing a custom `UpdateItemPivot`/
              `LockUpdateItem` nested-enum extension the game's fork added —
              recovered the real signatures from `il2cpp_dump/dump.cs`
              (Il2CppDumper's metadata dump, still on disk from Phase 0) and
              added them back by hand.
            - `UITweener.Play(bool)` needed to be `virtual` (confirmed via the
              same dump.cs) so `TweenLetters.Play` could override it.
            - `UISpriteCollection` (game-custom, extends `UIBasicSprite`)
              called an old-style `OnFill(List<Vector3>, List<Vector2>,
              List<Color>)`/`padding` API; the mirror uses newer
              `OnFill(BetterList<Vector3>, BetterList<Vector2>,
              BetterList<Color32>)` with no `padding` member at all — adjusted
              the one game-custom override rather than fighting the whole
              rendering pipeline back to the older API.
            - ~35 "obsolete member is now a hard error" issues (Unity 2022
              no longer implicitly resolves `.collider`/`.camera`/
              `.rigidbody`/`.animation`/`.renderer`/`.light`/`.audio` the way
              Unity 5-era NGUI code assumes) — mechanical `GetComponent<T>()`
              fixes across ~23 files, plus a few outright-removed API members
              (`RuntimePlatform.WindowsWebPlayer`/`OSXWebPlayer`,
              `Camera.isOrthoGraphic`, `BoxCollider2D.center`).
            - **Compiles clean, 0 errors**, verified via the same
              `-batchmode -nographics -quit` compile-check pattern used
              throughout this project.
      - [x] Implemented `JoyStick.cs` for real (drag-to-move with clamped
            radius, spring-back-to-center on release, direction events) and
            wired `UserButtonInputLayout`'s `Run`/`Jump`/`Dash`/`Attack`
            methods to the spawned entity's real `CharacterInput`/
            `MovementComponent` (same `RunRequest`/`JumpRequest`/`DashRequest`
            calls the validation harnesses already proved work).
      - [x] **Simplified `InitDungeonSystemCmd`/`DungeonContext` and got the
            real `Dungeon.unity` scene to boot end-to-end.** Deliberately
            scoped down (per the original plan) — skips monster spawning,
            camera bounds, achievements, daily quests, and the full
            cosmetic/equipment `SpawnMainCharacterCmd` pipeline, none of which
            movement/input testing needs:
            - `DungeonContextView.Awake()` → `DungeonContext` → `mapBindings()`
              binds `OnDungeonStartSignal` → `InitDungeonSystemCmd` and
              `UserButtonInputLayout` → `UserButtonInputLayoutMediator`;
              `Launch()` dispatches `OnDungeonStartSignal` to kick things off.
            - `InitDungeonSystemCmd.Execute()` now mirrors
              `RealCharacterValidationHarness`: builds a real `EntityWorld`
              with `MovementSystem`/`HeroStateMachineSystem`, spawns the real
              character prefab through `MainCharacterTemplate`/
              `EntityTemplateManager`, instantiates the real
              `guiprefabs/UserButtonInputController` Resources prefab (found
              by grepping scene/prefab YAML for the script GUID — the button
              layout isn't placed statically in `Dungeon.unity`, only loaded
              at runtime), and dispatches `OnSpawnMainCharacterSignal`.
            - New `DungeonSimulationDriver` (not part of the original game,
              same rationale as `HeroStateMachineComponent`/`System`): a
              `MonoBehaviour` that ticks `entityWorld.Update()` every frame,
              since a StrangeIoC `Command` only runs once and something needs
              to drive the ECS simulation afterward.
            - Hit and fixed two StrangeIoC gotchas along the way: (1) this
              game's `commandBinder` is a `SignalCommandBinder`, which
              unconditionally casts its binding key to `IBaseSignal` —
              binding a plain event value like `ContextEvent.START` compiles
              fine but throws `InvalidCastException` at runtime; (2) the
              `Injector` throws (rather than silently injecting null) for any
              `[Inject]` property with no binding, so every unused
              dependency (`IBattleModeLogic`, `AchievementLogic`,
              `ConfigManager`, etc.) had to be stripped from
              `InitDungeonSystemCmd`/`UserButtonInputLayoutMediator` rather
              than left in place — otherwise the command/mediator never gets
              constructed, silently blocking everything downstream.
          - **Verified via automated batchmode Play-mode smoke test**
            (`Assets/Editor/SmokeTestDungeon.cs`, same pattern as the
            validation harnesses): opens the real `Dungeon.unity`, enters
            Play mode, confirms `[InitDungeonSystemCmd] Simplified dungeon
            boot complete: main character spawned.` fires with zero
            exceptions. **This is the real game scene now, not a synthetic
            test scene.**

      **Update: `Dungeon.unity` is almost entirely empty (one GameObject,
      `DungeonContext`) + a systemic shader-recovery gap found via your
      interactive test.**
      - [x] Confirmed the *entire* level (terrain, camera, gates) is built
            procedurally at runtime by `Dungeon`/`DungeonFactory`/
            `DefaultStage`/`DefaultEnvironment`/`CameraComponent` — all still
            fully stub, a much bigger reimplementation effort than
            movement/input testing needs. Added a placeholder camera + ground
            plane + directional light (`DungeonSimulationDriver`, not part of
            the original game) just so the spawned character is visible for
            testing, not an attempt at the real level.
      - [x] **Found and fixed a systemic AssetRipper shader-recovery gap.**
            After the placeholder light was added, the character (and the
            placeholder ground) rendered as flat white — not a lighting bug.
            Traced the character's real body material
            (`1_1_body_Material.mat`, correctly assigned, real texture GUID
            present) to a custom shader (`kokichi/Mobile/Rim/MatCap/Textured`)
            that AssetRipper could not decompile back to real HLSL; it
            emitted a placeholder marked `//DummyShaderTextExporter` whose
            fragment shader is hardcoded to `return float4(1,1,1,1)` —
            solid white, ignoring every texture/light/property. Grepping the
            project found **232 shader files** with this same marker,
            meaning this affects most custom-shaded objects in the game, not
            just this one material. Wrote `Assets/Editor/SwapDummyShaders.cs`
            (not part of the original game) to batch-remap every material
            using one of these dummy shaders to Unity's built-in Standard
            shader, carrying over whichever texture property name-matches
            "base/main/diffuse/albedo" (falling back to the first available
            texture). Run via `-executeMethod SwapDummyShaders.Run`:
            **2194 materials swapped, 2095 with a texture carried over.**
            This is a visual approximation (real textures/lighting now show,
            but the game's actual rim-light/toon look is unrecoverable
            without hand-written replacement shaders — that's genuine Phase 7
            visual-parity work, not attempted here).
      - Next: your interactive confirmation that the character now renders
            with real texture/shading instead of flat white, and that
            joystick/button input works on-screen.

      **Update: your first interactive test found three more gaps, all
      fixed.** Confirmed via screenshot comparison against the real game
      (character silhouette/armor read correctly, but sword was flat white,
      lighting was much brighter/flatter than the real game's dark moody
      look, and the joystick/buttons never appeared on screen at all so
      input couldn't be tested).
      - [x] **Weapon rendering white** — different root cause than the
            shader-recovery gap above. The weapon's `SkinnedMeshRenderer` in
            `1_1_Prefab.prefab` has *no* material assigned at all — it
            references Unity's built-in `Default-Material` fallback
            (`guid: 0000000000000000f000000000000000`). The real game
            assigns the equipped weapon's material at runtime via
            `AbsSpawnCharacterCmd.ReplaceWeapon`, part of the full
            cosmetic/equipment pipeline this simplified boot skips.
            `InitDungeonSystemCmd.AssignDefaultWeaponMaterial` now finds the
            "weapon" child transform and assigns the character's actual
            default (non-cosmetic) weapon material
            (`equipment/weapon/default/material/1_1_weapon_Material.mat` —
            confirmed already fixed by the shader swap above, real texture
            included) directly.
      - [x] **Joystick/buttons never appeared, so input was untestable.**
            Root cause: `UserButtonInputController.prefab` has no
            `UIRoot`/`UIPanel`/`UICamera` of its own — it expects to be
            parented under a persistent UI root that the real game sets up
            once during the `EntryScene`→`LoadingScene` boot flow
            (`DontDestroyOnLoad`), confirmed by finding a `UICamera` in
            `LoadingScene.unity`/`SelectionScene.unity`/`TitleScene.unity`
            but *not* in `Dungeon.unity`, `EntryScene.unity`, or `Main.unity`
            — opening `Dungeon.unity` directly skips that setup entirely.
            `InitDungeonSystemCmd.SpawnPlaceholderUIRoot` now builds a
            minimal replacement (`UIRoot` + orthographic overlay `Camera` +
            `UICamera`, settings mirrored from the real `LoadingScene`
            camera: `ClearFlags=Depth only`, `orthographic size=1`,
            `Depth=99`, culling mask = the `UI` layer) and the button-layout
            prefab is instantiated as its child instead of a scene root.
      - [x] Verified via the same automated batchmode smoke test — zero
            exceptions after both fixes.
      - Still open from that test: character lighting/quality doesn't match
            the real game's darker, more stylized look (expected — the
            placeholder camera/light/Standard-shader setup is a rough
            visual stand-in, not the real rim/toon shading, which stays
            unrecoverable without hand-written replacement shaders per the
            shader-gap note above); the head appears slightly detached from
            the body in the idle pose (minor rigging/pose issue, not yet
            investigated); still no real terrain/level (known, separate
            `DungeonFactory` gap). Next: your interactive confirmation that
            the weapon now has a texture and the joystick/buttons are
            visible and respond to mouse clicks (keyboard input was never
            wired for this path — only NGUI touch/mouse, per the original
            game's control scheme).

      Systems still to do, in rough priority order:
      - [~] Player movement/controller — core classes done (see above),
            entity spawn orchestration still needed to see it run
      - [ ] Combat (attacks, hitboxes, damage)
      - [ ] Enemy AI / spawning
      - [ ] Skill tree / progression / stats
      - [ ] Save/load system
      - [ ] Level/stage flow & UI/menus
      - [ ] Any economy/IAP-adjacent systems (reimplement as stubs — not
            reconnecting real ad/payment SDKs)
- [ ] **Phase 7 — Android parity build.** Build to Android, play side-by-side
      against the original APK, iterate until behavior matches on the systems
      that matter.
- [ ] **Phase 8 — Windows export.** Switch Unity `Build Settings` platform to
      Windows Standalone, build, smoke-test input/UI scaling. Expected to be
      low-effort since it's the same project.
- [ ] **Phase 9 (optional, only if needed) — Targeted binary RE.** For any
      system where Phase 6 reimplementation can't be inferred confidently
      (precise formulas, RNG behavior, file formats), load `libil2cpp.so` +
      metadata into Ghidra via the Il2CppInspector script (auto-renames
      thousands of functions) and read the disassembly for just that system.

---

## 5. Environment gotchas (for picking this back up later)

- This machine has `ELECTRON_RUN_AS_NODE=1` set globally, which breaks every
  Electron-based CLI (Unity Hub included) by forcing it to run as plain Node
  instead of launching the app. Clear it per-call: `$env:ELECTRON_RUN_AS_NODE
  = $null` before invoking `Unity Hub.exe`.
- Unity Hub's CLI needs the double-dash form
  `"Unity Hub.exe" -- --headless <cmd>`, and PowerShell's call operator
  mangles this — invoke via `Start-Process -ArgumentList "--","--headless",...`
  with output redirected to a file, not `&` with inline args.
- `java -jar jadx-*-all.jar` launches the **GUI** by default (its manifest's
  Main-Class is the GUI entry point). For headless CLI decompilation, run
  `java -cp jadx-*-all.jar jadx.cli.JadxCLI -d <out> <apk>` instead, or use
  the `bin/jadx` wrapper script.
- Il2CppDumper.exe throws an unhandled exception on its final "press any key"
  prompt when stdin is non-interactive — harmless, the dump is already
  written by that point (check the output dir, not the exit code).
- Unity Editor requires an interactive Unity ID sign-in / Personal license
  activation through Unity Hub's GUI before `-batchmode` will run at all —
  this can't be scripted around, it's a one-time manual step per machine.
- **When restoring a third-party plugin from public source, check for
  "mega-files" before bulk-copying by filename.** AssetRipper/Il2CppDumper
  always reconstruct one `.cs` file per class (matching IL2CPP metadata,
  not the original project layout), but real upstream repos often bundle
  many classes into one file (Spine's `Animation.cs`/`Atlas.cs`, LeanTween's
  `LeanTween.cs`, the JSON libs, SevenZip's `RangeCoder.cs`). Copying the
  mega-file over its own matching stub is correct; but if the SAME
  mega-file's other nested classes also happen to match OTHER separate stub
  filenames, copying to those too creates duplicate-definition errors. Fix
  is always the same: delete the small superseded stub file, keep the
  mega-file. Never copy one multi-class source file to multiple destination
  filenames (self-inflicted "fan-out" duplication — happened once with
  SevenZip's RangeCoder/CommandLineParser/ICoder files here).
- Android SDK cmdline-tools installed standalone (not via Android Studio's
  GUI wizard) at `c:/.development/extractor/tools/android-sdk/`, driven
  entirely headlessly via `sdkmanager`/`avdmanager`/`emulator` CLIs — no need
  to ever open Android Studio's GUI for this. `sdkmanager --licenses` needs
  stdin fed from a file via `cmd /c "... < yes_input.txt"`; piping through
  PowerShell directly into the `.bat` wrapper doesn't reliably reach the
  underlying Java process's stdin.
- **Android Studio's own emulator cannot run this game at all**: its QEMU2
  backend refuses to boot an arm64 system image on an x86_64 host
  (`FATAL: Avd's CPU Architecture 'arm64' is not supported by the QEMU2
  emulator on x86_64 host`) — not a performance issue, a hard block, no
  software-emulation fallback in recent versions. Used **BlueStacks**
  instead (`C:\Program Files\BlueStacks_nxt\HD-Adb.exe` as the adb binary).
  Gotchas hit getting it working:
  - The default BlueStacks instance (`Nougat32`) is **32-bit** — installing
    the arm64-v8a-only APK fails with `INSTALL_FAILED_NO_MATCHING_ABIS`.
    Had to create a second, 64-bit instance via BlueStacks' **Multi-Instance
    Manager** GUI (Instance tab → install another instance → pick a 64-bit
    image) — this is GUI-only, no CLI way to create a new engine image. The
    resulting instance (`Pie64`, Android 9) reports
    `ro.product.cpu.abilist=x86_64,x86,arm64-v8a,armeabi-v7a,armeabi` and
    installs/runs the game fine.
  - BlueStacks accepts adb connections and lists the device as `device` even
    when its ADB bridge is only half-functional — `adb devices` succeeding
    is not proof `adb shell`/`adb install` will work. Had to enable
    **Settings → Advanced → "Android Debug Bridge (ADB)"** inside BlueStacks
    itself before `adb shell`/`install`/`push` stopped failing with
    `error: closed`.
  - After toggling that setting, `adb kill-server` + a fresh `adb devices`
    call is needed to pick it up.
  - Git Bash/MSYS2 mangles POSIX-looking paths like `/sdcard/foo.png` into
    Windows paths before they reach `adb`. Set
    `export MSYS2_ARG_CONV_EXCL="*"` before any `adb push/pull/shell` call
    involving on-device paths.
  - To drive the game from the shell: launch via
    `adb shell monkey -p com.Zonmob.ShadowofDeath.FightingGames -c
    android.intent.category.LAUNCHER 1`, screenshot via
    `adb shell screencap -p /sdcard/screen.png` then `adb pull`.

## 6. Open questions / risks

- AssetRipper's fidelity on Unity 2022.3 IL2CPP titles is generally strong for
  assets, but scene/prefab reconstruction can be partial — expect some manual
  scene rebuilding in Phase 5.
- Phase 6 is the real cost center — it's a genuine reimplementation effort, not
  a mechanical extraction. Scope it feature-by-feature rather than trying to
  match 100% of monetization/ad-related systems (those should just be dropped,
  not ported).
- No packer/obfuscator was detected on `libil2cpp.so`'s ELF header, but that's
  only the outer header — worth a quick sanity check once Il2CppDumper actually
  runs against it before assuming Phase 9 will be easy if it's ever needed.
