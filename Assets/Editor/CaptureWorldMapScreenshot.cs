using System.Collections;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;

// Not part of the original game. Same screenshot-capture approach as
// CaptureMainScreenshot.cs, driven further - through SelectionScene into
// the real WorldmapPopup - so the new dungeon-select screen could be
// visually verified before reporting it as done.
public static class CaptureWorldMapScreenshot
{
	private const string ActiveKey = "CaptureWorldMapScreenshot_Active";

	public static void Run()
	{
		EditorSceneManager.OpenScene("Assets/Scenes/Build/EntryScene.unity");
		Debug.Log("[CaptureWorldMapScreenshot] EntryScene opened, entering play mode...");
		SessionState.SetBool(ActiveKey, true);
		EditorApplication.isPlaying = true;
	}

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
	private static void AutoStart()
	{
		if (!SessionState.GetBool(ActiveKey, false))
		{
			return;
		}
		SessionState.SetBool(ActiveKey, false);

		GameObject driverGo = new GameObject("CaptureWorldMapScreenshotDriver");
		Object.DontDestroyOnLoad(driverGo);
		driverGo.AddComponent<CaptureWorldMapScreenshotDriver>();
	}
}

public class CaptureWorldMapScreenshotDriver : MonoBehaviour
{
	private void Start()
	{
		StartCoroutine(DriveRoutine());
	}

	private IEnumerator DriveRoutine()
	{
		float timeout = Time.realtimeSinceStartup + 30f;
		while (SceneManager.GetActiveScene().name != "TitleScene")
		{
			if (Time.realtimeSinceStartup > timeout)
			{
				Debug.LogError("[CaptureWorldMapScreenshot] Timed out waiting for TitleScene.");
				yield break;
			}
			yield return null;
		}
		yield return null;
		yield return null;

		TitleSceneView titleView = Object.FindObjectOfType<TitleSceneView>();
		if (titleView == null || titleView.clickArea == null)
		{
			Debug.LogError("[CaptureWorldMapScreenshot] Could not find TitleSceneView/clickArea.");
			yield break;
		}
		UICamera.Notify(titleView.clickArea, "OnClick", null);
		yield return null;
		yield return null;

		if (titleView.btn_loginGuest == null)
		{
			Debug.LogError("[CaptureWorldMapScreenshot] btn_loginGuest is unassigned.");
			yield break;
		}
		UICamera.Notify(titleView.btn_loginGuest, "OnClick", null);

		timeout = Time.realtimeSinceStartup + 15f;
		while (SceneManager.GetActiveScene().name != "Main")
		{
			if (Time.realtimeSinceStartup > timeout)
			{
				Debug.LogError("[CaptureWorldMapScreenshot] Timed out waiting for Main scene.");
				yield break;
			}
			yield return null;
		}
		yield return null;
		yield return null;
		yield return null;

		MainScenePopup mainPopup = Object.FindObjectOfType<MainScenePopup>();
		if (mainPopup == null || mainPopup.btn_adventure == null)
		{
			Debug.LogError("[CaptureWorldMapScreenshot] Could not find MainScenePopup/btn_adventure.");
			yield break;
		}
		UICamera.Notify(mainPopup.btn_adventure, "OnClick", null);

		timeout = Time.realtimeSinceStartup + 15f;
		while (SceneManager.GetActiveScene().name != "SelectionScene")
		{
			if (Time.realtimeSinceStartup > timeout)
			{
				Debug.LogError("[CaptureWorldMapScreenshot] Timed out waiting for SelectionScene.");
				yield break;
			}
			yield return null;
		}
		yield return null;
		yield return null;
		yield return null;

		Assets.Scripts.Ssar.CharacterSelection.View.SelectCharacterWidget selectWidget =
			Object.FindObjectOfType<Assets.Scripts.Ssar.CharacterSelection.View.SelectCharacterWidget>();
		if (selectWidget == null || selectWidget.btn_start == null)
		{
			Debug.LogError("[CaptureWorldMapScreenshot] Could not find SelectCharacterWidget/btn_start.");
			yield break;
		}
		UICamera.Notify(selectWidget.btn_start, "OnClick", null);
		Debug.Log("[CaptureWorldMapScreenshot] Clicked btn_start, waiting for WorldmapPopup...");

		WorldmapPopup worldmap = null;
		timeout = Time.realtimeSinceStartup + 15f;
		while (worldmap == null)
		{
			worldmap = Object.FindObjectOfType<WorldmapPopup>();
			if (Time.realtimeSinceStartup > timeout)
			{
				Debug.LogError("[CaptureWorldMapScreenshot] Timed out waiting for WorldmapPopup.");
				yield break;
			}
			yield return null;
		}

		yield return new WaitForSeconds(2f);

		string path = System.IO.Path.Combine(Application.dataPath, "../../worldmap_screenshot.png");
		path = System.IO.Path.GetFullPath(path);
		ScreenCapture.CaptureScreenshot(path);
		Debug.Log("[CaptureWorldMapScreenshot] Screenshot requested at: " + path);

		yield return null;
		yield return null;
		yield return new WaitForSeconds(1f);

		Debug.Log("[CaptureWorldMapScreenshot] SUCCESS: capture flow complete.");
	}
}
