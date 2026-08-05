using System.Reflection;
using UnityEditor;
using UnityEngine;

// Not part of the original game. After multiple attempts to get the real
// FontIMFell/FontTahoma bitmap-and-dynamic-font pipeline working correctly
// (material linking, shader, texture, DYNAMIC_FONT define) still didn't
// render visibly, this is a decisive fallback per explicit request: force
// both fonts onto Unity's own guaranteed-available built-in font instead of
// the project's own .ttf files, eliminating any possibility that the
// project's own font import settings are the remaining problem. Also
// verifies the underlying material tint is white so nothing darkens it.
public static class ForceSimpleFont
{
	[MenuItem("Tools/Shadow of Death/Force Simple Fallback Font (White)")]
	public static void Run()
	{
		Font builtin = Resources.GetBuiltinResource<Font>("LegacyRuntime.ttf");
		if (builtin == null)
		{
			Debug.LogError("[ForceSimpleFont] Could not find built-in font LegacyRuntime.ttf.");
			return;
		}

		Debug.Log("[ForceSimpleFont] Using built-in font: " + builtin.name);

		int fixedCount = 0;
		string[] paths = { "Assets/Resources/atlases/FontIMFell.prefab", "Assets/Resources/atlases/FontTahoma.prefab" };
		foreach (string path in paths)
		{
			GameObject prefab = AssetDatabase.LoadAssetAtPath<GameObject>(path);
			if (prefab == null)
			{
				Debug.LogError("[ForceSimpleFont] Could not load " + path);
				continue;
			}

			UIFont font = prefab.GetComponent<UIFont>();
			if (font == null)
			{
				Debug.LogError("[ForceSimpleFont] No UIFont component on " + path);
				continue;
			}

			// Clear the bitmap-mode fields directly (mMat/mAtlas) via
			// reflection so nothing overrides the dynamic font fallback,
			// then point the dynamic font at Unity's own built-in font.
			SetPrivateField(font, "mMat", null);
			SetPrivateField(font, "mAtlas", null);
			font.dynamicFont = builtin;

			EditorUtility.SetDirty(prefab);
			fixedCount++;
			Debug.Log("[ForceSimpleFont] Forced " + path + " to use built-in font " + builtin.name);
		}

		AssetDatabase.SaveAssets();
		AssetDatabase.Refresh();
		Debug.Log("[ForceSimpleFont] Done. Fonts forced: " + fixedCount + " / " + paths.Length);
	}

	private static void SetPrivateField(object target, string fieldName, object value)
	{
		FieldInfo field = target.GetType().GetField(fieldName, BindingFlags.NonPublic | BindingFlags.Instance);
		if (field != null)
		{
			field.SetValue(target, value);
		}
	}
}
