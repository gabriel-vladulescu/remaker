using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.Ssar.Main
{
	// Main.unity has no scene-specific controller placed in it at all (just
	// UIPanel/UIRoot/TouchEffects/Reporter debug tools) - same situation as
	// Dungeon.unity before DungeonSimulationDriver. The real game's actual
	// hub UI (MainScenePopup.prefab, Resources/guiprefabs/main/) is
	// instantiated at runtime; the real trigger for that is presumably
	// CheckAndLoadMainSceneCmd (a big async asset-preload pipeline this
	// project doesn't reimplement - see PLAN.md). This is a much simpler
	// stand-in: whenever Main.unity becomes the active scene, instantiate
	// the popup directly. Not part of the original game.
	public class MainSceneBootstrap : MonoBehaviour
	{
		private const string MainScenePopupResourcePath = "guiprefabs/main/MainScenePopup";

		// Added as a component onto GameInitController's own GameObject,
		// which is already DontDestroyOnLoad - no need to mark it again here.
		private void Awake()
		{
			SceneManager.sceneLoaded += OnSceneLoaded;
		}

		private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
		{
			if (scene.name != "Main")
			{
				return;
			}

			GameObject prefab = Resources.Load<GameObject>(MainScenePopupResourcePath);
			if (prefab == null)
			{
				Debug.LogError("[MainSceneBootstrap] Could not load prefab at Resources/" + MainScenePopupResourcePath);
				return;
			}

			Instantiate(prefab);
		}
	}
}
