using System.IO;
using System.Reflection;
using UnityEditor;
using UnityEngine;

// Not part of the original game. AssetRipper's reconstruction of every
// UIAtlas/UIFont prefab in this project left their material reference null
// (UIAtlas.material / UIFont.mMat both {fileID: 0}), even though the real
// .mat file (and its .png texture) sits right next to each prefab, correctly
// imported, just not linked back. This is why text and atlas-sourced
// sprites throughout the UI render as solid black/tinted shapes instead of
// real glyphs/art - not a missing-asset problem, a broken-reference one.
// Re-links every one of them by matching filename (FontIMFell.prefab ->
// FontIMFell.mat, UIInterface.prefab -> UIInterface.mat, etc.) via the real,
// restored NGUI UIAtlas.spriteMaterial / UIFont.material properties.
//
// Second gap found once the reference itself was fixed: these 33 .mat files
// also carry the wrong shader (Standard - the same builtin fileID 46 that
// SwapDummyShaders.cs assigned to ~2200 3D character/effect materials
// earlier this project). Standard is a lit/opaque PBR shader; applied to a
// flat UI text/sprite quad it renders as a dim, opaque, tinted-by-ambient-
// light rectangle instead of the real transparent glyph/sprite art (the
// "brown boxes instead of text" symptom). Real NGUI code (UITexture.cs,
// UI2DSprite.cs) hardcodes its actual default as "Unlit/Transparent
// Colored" - reassigning that here, scoped only to these 33 UI materials so
// the earlier character-shader fix elsewhere in the project is untouched.
public static class FixAtlasFontMaterials
{
	[MenuItem("Tools/Shadow of Death/Fix Atlas and Font Materials")]
	public static void Run()
	{
		int fixedCount = 0;
		int alreadyOk = 0;
		int noMaterialFound = 0;
		int shadersFixed = 0;

		Shader correctShader = Shader.Find("Unlit/Transparent Colored");
		if (correctShader == null)
		{
			Debug.LogError("[FixAtlasFontMaterials] Could not find built-in shader 'Unlit/Transparent Colored' - aborting shader fix (reference fix below still runs).");
		}

		string[] guids = AssetDatabase.FindAssets("t:Prefab", new[] { "Assets/Resources" });
		foreach (string guid in guids)
		{
			string path = AssetDatabase.GUIDToAssetPath(guid);
			GameObject prefab = AssetDatabase.LoadAssetAtPath<GameObject>(path);
			if (prefab == null)
			{
				continue;
			}

			bool changed = false;

			UIAtlas atlas = prefab.GetComponent<UIAtlas>();
			if (atlas != null)
			{
				if (atlas.spriteMaterial == null)
				{
					Material mat = FindSiblingMaterial(path);
					if (mat != null)
					{
						atlas.spriteMaterial = mat;
						changed = true;
						fixedCount++;
					}
					else
					{
						noMaterialFound++;
						Debug.LogWarning("[FixAtlasFontMaterials] No sibling .mat found for atlas: " + path);
					}
				}
				else
				{
					alreadyOk++;
				}

				if (FixShader(atlas.spriteMaterial, correctShader))
				{
					shadersFixed++;
				}
			}

			UIFont font = prefab.GetComponent<UIFont>();
			if (font != null)
			{
				// font.material isn't reliable here: its getter falls back
				// to mDynamicFont.material (a real, non-null Unity Font
				// material) whenever mMat/mAtlas are both null - several
				// fonts in this project (e.g. FontIMFell, FontTahoma) have
				// a dynamic-font fallback configured, so that getter
				// silently returned non-null and this branch never ran the
				// first time. These fonts are used in bitmap mode though
				// (real baked glyph rects in mFont), which needs mMat set
				// directly - read/write the private field via reflection
				// to bypass the misleading fallback.
				FieldInfo mMatField = typeof(UIFont).GetField("mMat", BindingFlags.NonPublic | BindingFlags.Instance);
				object currentMat = mMatField != null ? mMatField.GetValue(font) : "REFLECTION_FIELD_NOT_FOUND";
				if (mMatField != null && currentMat == null)
				{
					Material mat = FindSiblingMaterial(path);
					if (mat != null)
					{
						font.material = mat;
						changed = true;
						fixedCount++;
					}
					else
					{
						noMaterialFound++;
						Debug.LogWarning("[FixAtlasFontMaterials] No sibling .mat found for font: " + path);
					}
				}
				else
				{
					alreadyOk++;
				}

				if (FixShader(font.material, correctShader))
				{
					shadersFixed++;
				}
			}

			if (changed)
			{
				EditorUtility.SetDirty(prefab);
			}
		}

		AssetDatabase.SaveAssets();
		AssetDatabase.Refresh();
		Debug.Log("[FixAtlasFontMaterials] Done. Reference fixed: " + fixedCount + ", already OK: " + alreadyOk
			+ ", no material found: " + noMaterialFound + ", shaders corrected to Unlit/Transparent Colored: " + shadersFixed);
	}

	private static bool FixShader(Material mat, Shader correctShader)
	{
		if (mat == null || correctShader == null || mat.shader == correctShader)
		{
			return false;
		}
		mat.shader = correctShader;
		EditorUtility.SetDirty(mat);
		return true;
	}

	private static Material FindSiblingMaterial(string prefabPath)
	{
		string matPath = Path.ChangeExtension(prefabPath, ".mat");
		return AssetDatabase.LoadAssetAtPath<Material>(matPath);
	}
}
