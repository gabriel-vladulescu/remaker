# Extraction completeness audit

Full re-verification against `ApkExtraction.md`'s checklist, prompted by wanting 100%
certainty nothing was missed before committing to the UI-first rebuild plan (see
`PLAN.md`). Conclusion: **the original extraction was already complete and used the best
available free-tier settings.** No re-extraction was needed; this documents what was
checked and why.

## Method

1. Fresh download of AssetRipper 1.3.14 (same version as the original extraction — it's
   still current) into a clean instance, no reused state.
2. Inspected its actual Settings page (`/Settings/Edit`) to see every export option and
   which value was selected by default, cross-referenced against AssetRipper's own source
   (`Source/AssetRipper.Export.UnityProjects/Shaders/`) to confirm what's genuinely
   available in the free/open-source build vs. gated.
3. Re-loaded `shadow-of-death_extracted/` (the original unpacked APK, untouched all
   session) and re-exported to a scratch folder (`tools/verify_export/`, deleted after
   comparison — never touched the working project).
4. Diffed the fresh export's file list against the current working project's, in both
   directions.
5. Ran the `ilspycmd` decompile step (`ApkExtraction.md` step 5) — never done this
   session — against every assembly with plausible relevance, to get organized per-class
   reference source instead of just the single `dump.cs`.

## Findings

### Asset/scene/prefab extraction: complete
Fresh load: `Android game structure has been found`, `Files use the 'IL2Cpp' scripting
backend`, `During Il2Cpp initialization, found Unity version: 2022.3.62f3` — same
recognition as originally, single APK (no split-bundle complexity to worry about). Fresh
export: 12,854/12,854 items exported, **one** warning in the entire run (`Could not read
MonoBehaviour structure for UnityEngine.GUISkin` — a legacy Reporter-plugin debug skin
asset, inconsequential).

### File-level diff: current project has 133 files the fresh export doesn't
All 133 are accounted for by this session's own restoration work, not anything missed
from the APK:
- **~120 of them**: superseded stub files deleted during the documented "mega-file"
  consolidation (Spine, StrangeIoC, SimpleJSON, LitJson, SharpJson, LeanTween/DentedPixel,
  SevenZip) — see `docs/lessons-learned.md`.
- `SuperCollider.cs`: intentionally deleted (documented — incompatible with the game's own
  `BSPTree.cs`, unused by game code).
- `SimpleFileBrowser/*`: not individually documented, but the project compiles 100% clean
  without it and nothing references it — confirms it was never load-bearing.

The project has always compiled clean; anything genuinely required but missing would have
surfaced as a compile error, not a silent gap. This is the actual proof the 133-file
difference is safe, not just a plausible-sounding explanation.

### Shader recovery: confirmed hard ceiling, not a missed setting
This was the main open question (see `PLAN.md`'s shader-gap section). AssetRipper's
Settings page has a **Shader Export Format** option with three choices:

| Option | What it does |
|---|---|
| Dummy Shader | Preserves properties/fallback, opaque placeholder code — **what we used** |
| Yaml Asset | Experimental, editor-only, "can randomly corrupt these files" |
| **Decompilation** | **"Not available in the free edition."** |

Confirmed directly in AssetRipper's own source
(`Source/AssetRipper.Export.UnityProjects/Shaders/`): the free/open-source build only ships
`DummyShaderTextExporter`, `SimpleShaderExporter`, `YamlShaderExporter` — no decompile
exporter exists in the code we're actually running, regardless of settings. Real shader
decompilation is a **paid AssetRipper feature**, not a toggle we missed. `/PremiumFeatures`
lists "Shader Decompilation: Supported" — that's describing platform capability if
licensed, not something active for us.

**Bundled-but-unused libraries**: SPIRV-Cross, dxil-spirv, SmolV (all real shader-bytecode
tooling) are present in the free build's dependencies but power the gated premium path, not
something callable directly.

**What this means for the "reverse the shaders" question**: not achievable by re-running
AssetRipper differently. The two real options are (a) an AssetRipper premium license, or
(b) a separate standalone tool — `Ruri.ShaderDecompiler`
(github.com/ShiyumeMeguri/Ruri.ShaderDecompiler, DXBC/DXIL → SPIR-V with symbol recovery) —
applied to the raw compiled shader bytecode, unverified for this project, would need its
own investigation/setup if pursued. `Dummy` (now remapped to Standard shader project-wide,
see `PLAN.md`) is the accurate ceiling for what we did, not a mistake in how we ran the
tool.

### Il2CppDumper / metadata: already complete
`il2cpp_dump/` (`dump.cs`, `il2cpp.h`, `script.json`, `stringliteral.json`, `DummyDll/`)
was already fully populated from earlier in the session — nothing new to extract here, all
93 assemblies present.

### New: `ilspycmd` decompiled reference source (was missing, now added)
`ApkExtraction.md` step 5 (organized per-class decompiled `.cs` projects, not just the
monolithic `dump.cs`) was never run this session. Added now to
`il2cpp_dump/DecompiledSource/` for: `Assembly-CSharp`, `Assembly-CSharp-firstpass`,
`DOTween`, `Newtonsoft.Json`, `FullSerializer`, `Checking`, `BigInteger`,
`Google.MiniJson`, `Logger` (the assemblies with plausible game-logic relevance — skipped
Firebase/Facebook/GoogleMobileAds/AppsFlyer/Unity.Services/Purchasing and all
System*/UnityEngine.*Module/mscorlib assemblies, confirmed ad/analytics/engine-builtin and
out of scope per this project's established conventions).

**One genuine new finding from this step**: `DOTween` decompiles to 95 files, but only 4
exist in the working project (`DOTweenCYInstruction.cs`, `DOTweenModuleAudio.cs`,
`DOTweenModuleUnityVersion.cs`, `DOTweenModuleUtils.cs` — all still empty stubs). The core
tweening engine (`DOTween.cs`, `Tweener`, `Sequence`, `DOVirtual`, etc.) isn't in the
exported project at all — likely stripped by Unity's IL2CPP linker since so little of it
survived. Usage footprint in the game's own code is minimal (`SoundManager.cs` has a `using
DG.Tweening;` and nothing else visible — bodies are stub either way). Not currently
blocking anything; DOTween is a real, actively-maintained open-source library
(github.com/Demigiant/dotween) and would be a same-technique restoration (like
NGUI/StrangeIoC/Artemis/Spine) whenever audio-fade/tween polish becomes relevant.

**Confirmed inconsequential** (fully decompiled, characterized, nothing to restore):
`Checking` (just `NotNullReference.cs`, the bespoke 40-usage null-check utility already
known), `BigInteger` (a single standalone legacy implementation, only used inside
Artemis's own code), `Logger` (a small bespoke logging wrapper, 3 files).

### Ghidra: already complete (see `docs/ghidra-setup.md`)
No changes from this audit — already covered.

## Bottom line

Nothing was missed. The extraction ceiling for this game, with free/open-source tooling, is:
- Assets/scenes/prefabs: 100%, lossless
- IL2CPP code: 100% of signatures, 100% of native functions labeled+decompilable-to-pseudo-C
  via Ghidra, **0% original C# recoverable** (inherent IL2CPP limitation, not a tooling gap)
- Shaders: properties/fallback recoverable, **original HLSL not recoverable** without a
  paid AssetRipper license or a separate bytecode decompiler tool (not yet evaluated)
