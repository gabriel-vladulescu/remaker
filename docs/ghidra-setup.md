# Ghidra setup for Shadow of Death — working, verified

Full IL2CPP symbol labeling of `libil2cpp.so` is done and verified. This documents the
exact paths/commands so it can be reused (re-run verification queries, or redo the import
if the project is ever lost) without rediscovering the recipe. See
`ApkExtraction.md` §6 (`C:\Users\user\Desktop\ApkExtraction.md`) for *why* this specific
approach (plain Java scripts, not the bundled Python/Jython ones) is necessary — four
dead-end attempts are documented there so they don't get repeated.

## What's where

| Thing | Path |
|---|---|
| Ghidra project (`.gpr`/`.rep`) | `C:\Users\user\Desktop\ShadowOfDeath_GhidraProject\ShadowOfDeathIL2CPP.gpr` |
| JDK 21 (reused from the Fruit Ninja RE project — Ghidra 12.x needs 21, not 17) | `C:\Users\user\Desktop\Fruit-Ninja-Clone-master\RE_Tools\jdk21\jdk-21.0.12+8` |
| Ghidra 12.1.2 install (also reused) | `C:\Users\user\Desktop\Fruit-Ninja-Clone-master\RE_Tools\ghidra_12.1.2_PUBLIC` |
| Labeling scripts (this project's copy) | `c:\.development\extractor\tools\ghidra_scripts\` (`DisableSlowAnalyzers.java`, `LabelIl2Cpp.java`, plus `VerifyLabels.java`/`FindClass.java` used only for verification) |
| Input binary | `c:\.development\extractor\shadow-of-death_extracted\lib\arm64-v8a\libil2cpp.so` (61 MB) |
| `script.json` (address→name map, from Il2CppDumper) | `c:\.development\extractor\il2cpp_dump\script.json` |

**Important**: the Ghidra project deliberately lives *outside* `c:\.development\extractor\`
— Ghidra's project-path validator rejects any dot-prefixed path component
(`.development`), so `c:\.development\extractor\tools\GhidraProject` fails immediately with
`Path element starting with '.' is not permitted`. Only the project location is affected;
`-import`/`-scriptPath` arguments pointing back into `.development` work fine.

## Result (verified)

- **165,038 / 192,439 functions** have real recovered C#-style names (`Namespace.Class$$Method`)
- **20,219** string literals labeled
- **60,240** additional functions created from `script.json`'s address list beyond what
  Ghidra's own auto-analysis found
- Confirmed present and findable: every class this session touched —
  `GameInitController`, `TitleSceneView`, `MovementSystem`, `HeroStateMachine`,
  `InitDungeonSystemCmd`, `LoadingSceneView`, `MainScenePopup`, `CameraComponent`,
  `DungeonFactory` (including `DungeonFactory$$CreateDungeon`/`CreateStages`/
  `CreateGates`/`CreateStageActivators`/`CreateGoals`/`CreateLosingConditions`/
  `CreateChallenges` — the real level-generation system, left as pure guesswork/stub this
  session since `Dungeon.unity` itself is nearly empty; this is now the first place to look
  when actually implementing it)

Total headless analysis + labeling time: ~30 minutes (`Total Time 1769 secs` for the main
analysis pass alone, per the run log).

## Re-running the import from scratch (if the project is ever lost/corrupted)

```powershell
$env:JAVA_HOME = "C:\Users\user\Desktop\Fruit-Ninja-Clone-master\RE_Tools\jdk21\jdk-21.0.12+8"
$env:PATH = "$env:JAVA_HOME\bin;$env:PATH"
$ghidra = "C:\Users\user\Desktop\Fruit-Ninja-Clone-master\RE_Tools\ghidra_12.1.2_PUBLIC\support\analyzeHeadless.bat"
$projectDir = "C:\Users\user\Desktop\ShadowOfDeath_GhidraProject"   # must not contain a dot-prefixed path segment
if (Test-Path $projectDir) { Remove-Item $projectDir -Recurse -Force }   # always start clean - a killed/failed prior run leaves a project lock
New-Item -ItemType Directory -Force -Path $projectDir | Out-Null

& $ghidra $projectDir ShadowOfDeathIL2CPP `
  -import "c:\.development\extractor\shadow-of-death_extracted\lib\arm64-v8a\libil2cpp.so" `
  -scriptPath "c:\.development\extractor\tools\ghidra_scripts" `
  -preScript DisableSlowAnalyzers.java `
  -postScript LabelIl2Cpp.java "c:\.development\extractor\il2cpp_dump\script.json" `
  -analysisTimeoutPerFile 36000
```

## Querying an already-analyzed project (fast, no re-analysis)

Use `-process <program name> -noanalysis` instead of `-import` to run a script against the
existing project without re-analyzing:

```powershell
& $ghidra $projectDir ShadowOfDeathIL2CPP `
  -process libil2cpp.so -noanalysis `
  -scriptPath "c:\.development\extractor\tools\ghidra_scripts" `
  -postScript FindClass.java
```

`FindClass.java` in `tools/ghidra_scripts/` takes a hardcoded list of class-name substrings
and prints matching function names/addresses — edit the `needles` array to search for
whatever class you're currently trying to understand, this is the fast way to find the
right entry point before opening the GUI decompiler on it.

## Browsing interactively (to actually read decompiled pseudo-C for a specific method)

```
set JAVA_HOME=C:\Users\user\Desktop\Fruit-Ninja-Clone-master\RE_Tools\jdk21\jdk-21.0.12+8
C:\Users\user\Desktop\Fruit-Ninja-Clone-master\RE_Tools\ghidra_12.1.2_PUBLIC\ghidraRun.bat
```
Open the `ShadowOfDeathIL2CPP` project → `libil2cpp.so` → Symbol Tree or Go To (Ctrl+G) →
paste the real name (e.g. `Assets.Scripts.Ssar.Dungeon.DungeonFactory$$CreateDungeon`) →
Decompile panel on the right shows readable (if not literally C#) pseudo-C, correctly
named and cross-referenced. This is a GUI application — needs to be run interactively by
whoever wants to read a specific function, not something scriptable end-to-end from here.
For a non-interactive "just print me this one function's pseudo-C to a file" need, write a
small script using Ghidra's `DecompInterface` API (not set up yet — the two proven scripts
here only label, they don't decompile-to-text).
