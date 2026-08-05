using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

// Not part of the original game. SwapDummyShaders.cs (earlier this project)
// blanket-remapped every AssetRipper "Dummy" shader project-wide to Unity's
// built-in Standard shader - a reasonable fallback for opaque 3D character
// materials, but wrong for particle effect materials (glow/spark/flame),
// which need additive blending to look like glowing VFX instead of solid
// opaque shapes. Scoped fix: only touches materials actually assigned to a
// Renderer on a GameObject with a ParticleSystem component, and only when
// that material is still on the wrong Standard shader.
public static class FixParticleShaders
{
	[MenuItem("Tools/Shadow of Death/Fix Particle Shaders")]
	public static void Run()
	{
		Shader standard = Shader.Find("Standard");
		Shader additive = Shader.Find("Particles/Additive");
		if (additive == null)
		{
			additive = Shader.Find("Mobile/Particles/Additive");
		}
		if (additive == null)
		{
			additive = Shader.Find("Legacy Shaders/Particles/Additive");
		}
		if (additive == null)
		{
			additive = Shader.Find("Particles/Standard Unlit");
		}
		if (additive == null)
		{
			Debug.LogError("[FixParticleShaders] Could not find any built-in additive particle shader (tried Particles/Additive, Mobile/Particles/Additive, Legacy Shaders/Particles/Additive, Particles/Standard Unlit).");
			return;
		}
		Debug.Log("[FixParticleShaders] Using shader: " + additive.name);

		string[] prefabGuids = AssetDatabase.FindAssets("t:Prefab", new[] { "Assets/Resources" });
		HashSet<string> fixedMaterialPaths = new HashSet<string>();
		int fixedCount = 0;

		foreach (string guid in prefabGuids)
		{
			string path = AssetDatabase.GUIDToAssetPath(guid);
			GameObject prefab = AssetDatabase.LoadAssetAtPath<GameObject>(path);
			if (prefab == null)
			{
				continue;
			}

			foreach (ParticleSystem ps in prefab.GetComponentsInChildren<ParticleSystem>(includeInactive: true))
			{
				Renderer renderer = ps.GetComponent<Renderer>();
				if (renderer == null)
				{
					continue;
				}

				bool changedThisRenderer = false;
				Material[] mats = renderer.sharedMaterials;
				for (int i = 0; i < mats.Length; i++)
				{
					Material mat = mats[i];
					if (mat == null || mat.shader != standard)
					{
						continue;
					}

					string matPath = AssetDatabase.GetAssetPath(mat);
					if (!fixedMaterialPaths.Contains(matPath))
					{
						mat.shader = additive;
						EditorUtility.SetDirty(mat);
						fixedMaterialPaths.Add(matPath);
						fixedCount++;
						Debug.Log("[FixParticleShaders] Fixed material '" + matPath + "' (used by particle system on '" + ps.gameObject.name + "' in " + path + ")");
					}
					changedThisRenderer = true;
				}

				if (changedThisRenderer)
				{
					EditorUtility.SetDirty(prefab);
				}
			}
		}

		AssetDatabase.SaveAssets();
		AssetDatabase.Refresh();
		Debug.Log("[FixParticleShaders] Done. Materials fixed: " + fixedCount);
	}
}
