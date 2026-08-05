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

			FixMainCamera();

			GameObject prefab = Resources.Load<GameObject>(MainScenePopupResourcePath);
			if (prefab == null)
			{
				Debug.LogError("[MainSceneBootstrap] Could not load prefab at Resources/" + MainScenePopupResourcePath);
				return;
			}

			// Must be parented under the scene's real UIRoot, not
			// instantiated at scene root: UIRoot scales its whole
			// hierarchy down (here, to roughly 2/Screen.height, NGUI's
			// standard "PixelPerfect" convention) so pixel-authored,
			// ~1280x720-sized UI fits inside the UI camera's small
			// orthographic view. Without that inherited scale,
			// MainScenePopup's geometry is ~350x too large for the
			// camera's field of view - the camera ends up looking at an
			// effectively empty, deeply-zoomed-in fragment of it, which
			// is why the screen previously stayed solid black even
			// though every component involved was individually healthy.
			UIRoot uiRoot = Object.FindObjectOfType<UIRoot>();
			Transform parent = uiRoot != null ? uiRoot.transform : null;
			Instantiate(prefab, parent);
		}

		// Main.unity's own camera (child of the scene's real UIRoot/UIPanel,
		// which are otherwise correctly set up at the same 1280x720
		// FixedSize LoadingScene uses) has ClearFlags=Depth only and a
		// culling mask that doesn't include the UI layer MainScenePopup's
		// content actually lives on. Depth-only clear flags never redraws
		// the color buffer, so - with no other camera underneath to do
		// that - the previous scene's last rendered frame just stays
		// visually frozen on screen forever, even though the scene has
		// genuinely changed (confirmed via SceneManager). Also missing a
		// UICamera component, so NGUI's touch/click event dispatch
		// wouldn't have worked here either. Fixing in place rather than
		// spawning a second camera, since the UIRoot/UIPanel hierarchy
		// this camera already sits under is otherwise correct.
		private void FixMainCamera()
		{
			Camera cam = Object.FindObjectOfType<Camera>();
			if (cam == null)
			{
				Debug.LogError("[MainSceneBootstrap] No Camera found in Main scene.");
				return;
			}

			cam.clearFlags = CameraClearFlags.SolidColor;
			cam.backgroundColor = Color.black;
			cam.cullingMask = LayerMask.GetMask("UI");

			if (cam.GetComponent<UICamera>() == null)
			{
				cam.gameObject.AddComponent<UICamera>();
			}
		}
	}
}
