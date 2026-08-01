using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

// AssetRipper couldn't decompile ~232 of this game's custom shaders back to
// real HLSL source; it emitted placeholder shaders instead (marked with a
// "//DummyShaderTextExporter" comment) whose fragment shader always returns
// solid white regardless of textures/lighting/properties. Not part of the
// original game. Remaps every material using one of those dummy shaders to
// Unity's built-in Standard shader, carrying over whichever texture property
// looks like the base/main texture, so real textures and lighting show
// instead of flat white. This is a visual approximation, not a faithful
// recreation of the game's actual (unrecoverable) rim-light/toon shading -
// that would need hand-written replacement shaders, a separate, larger task.
public static class SwapDummyShaders
{
	private static readonly string[] BaseTextureNameHints = { "base", "main", "diffuse", "albedo" };

	public static void Run()
	{
		HashSet<string> dummyShaderGuids = FindDummyShaderGuids();
		Debug.Log("[SwapDummyShaders] Found " + dummyShaderGuids.Count + " dummy shaders.");

		Shader standard = Shader.Find("Standard");
		if (standard == null)
		{
			Debug.LogError("[SwapDummyShaders] Could not find the built-in Standard shader.");
			return;
		}

		string[] matGuids = AssetDatabase.FindAssets("t:Material");
		int swapped = 0;
		int textureCarried = 0;

		foreach (string matGuid in matGuids)
		{
			string matPath = AssetDatabase.GUIDToAssetPath(matGuid);
			Material mat = AssetDatabase.LoadAssetAtPath<Material>(matPath);
			if (mat == null || mat.shader == null)
			{
				continue;
			}

			string shaderPath = AssetDatabase.GetAssetPath(mat.shader);
			string shaderGuid = AssetDatabase.AssetPathToGUID(shaderPath);
			if (!dummyShaderGuids.Contains(shaderGuid))
			{
				continue;
			}

			Texture mainTex = FindBestTexture(mat);
			mat.shader = standard;
			if (mainTex != null)
			{
				mat.SetTexture("_MainTex", mainTex);
				textureCarried++;
			}
			EditorUtility.SetDirty(mat);
			swapped++;
		}

		AssetDatabase.SaveAssets();
		Debug.Log("[SwapDummyShaders] Swapped " + swapped + " materials to Standard shader (" + textureCarried + " with a carried-over texture).");
	}

	private static HashSet<string> FindDummyShaderGuids()
	{
		HashSet<string> result = new HashSet<string>();
		string[] shaderGuids = AssetDatabase.FindAssets("t:Shader");
		foreach (string guid in shaderGuids)
		{
			string path = AssetDatabase.GUIDToAssetPath(guid);
			if (!path.EndsWith(".shader"))
			{
				continue;
			}
			string text = File.ReadAllText(path);
			if (text.Contains("DummyShaderTextExporter"))
			{
				result.Add(guid);
			}
		}
		return result;
	}

	private static Texture FindBestTexture(Material mat)
	{
		Shader shader = mat.shader;
		int count = ShaderUtil.GetPropertyCount(shader);

		for (int i = 0; i < count; i++)
		{
			if (ShaderUtil.GetPropertyType(shader, i) != ShaderUtil.ShaderPropertyType.TexEnv)
			{
				continue;
			}
			string propName = ShaderUtil.GetPropertyName(shader, i);
			string lower = propName.ToLowerInvariant();
			bool looksLikeBase = false;
			foreach (string hint in BaseTextureNameHints)
			{
				if (lower.Contains(hint))
				{
					looksLikeBase = true;
					break;
				}
			}
			if (!looksLikeBase)
			{
				continue;
			}
			Texture tex = mat.GetTexture(propName);
			if (tex != null)
			{
				return tex;
			}
		}

		// Fallback: first non-null texture property of any name.
		for (int i = 0; i < count; i++)
		{
			if (ShaderUtil.GetPropertyType(shader, i) != ShaderUtil.ShaderPropertyType.TexEnv)
			{
				continue;
			}
			string propName = ShaderUtil.GetPropertyName(shader, i);
			Texture tex = mat.GetTexture(propName);
			if (tex != null)
			{
				return tex;
			}
		}

		return null;
	}
}
