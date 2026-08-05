using System.Collections;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;

// Not part of the original game. Lets a screenshot of a running scene be
// captured and inspected without needing a human to open the Editor and
// look - drives the same click-through flow as SmokeTestFullFlow up to
// Main (real INVENTORY/etc. NGUI text visible there) and saves a PNG.
public static class CaptureMainScreenshot
{
	private const string ActiveKey = "CaptureMainScreenshot_Active";

	public static void Run()
	{
		EditorSceneManager.OpenScene("Assets/Scenes/Build/EntryScene.unity");
		Debug.Log("[CaptureMainScreenshot] EntryScene opened, entering play mode...");
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

		GameObject driverGo = new GameObject("CaptureMainScreenshotDriver");
		Object.DontDestroyOnLoad(driverGo);
		driverGo.AddComponent<CaptureMainScreenshotDriver>();
	}
}

public class CaptureMainScreenshotDriver : MonoBehaviour
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
				Debug.LogError("[CaptureMainScreenshot] Timed out waiting for TitleScene.");
				yield break;
			}
			yield return null;
		}
		yield return null;
		yield return null;

		TitleSceneView titleView = Object.FindObjectOfType<TitleSceneView>();
		if (titleView == null || titleView.clickArea == null)
		{
			Debug.LogError("[CaptureMainScreenshot] Could not find TitleSceneView/clickArea.");
			yield break;
		}
		UICamera.Notify(titleView.clickArea, "OnClick", null);
		yield return null;
		yield return null;

		if (titleView.btn_loginGuest == null)
		{
			Debug.LogError("[CaptureMainScreenshot] btn_loginGuest is unassigned.");
			yield break;
		}
		UICamera.Notify(titleView.btn_loginGuest, "OnClick", null);

		timeout = Time.realtimeSinceStartup + 15f;
		while (SceneManager.GetActiveScene().name != "Main")
		{
			if (Time.realtimeSinceStartup > timeout)
			{
				Debug.LogError("[CaptureMainScreenshot] Timed out waiting for Main scene.");
				yield break;
			}
			yield return null;
		}

		// Give MainSceneBootstrap time to instantiate MainScenePopup and
		// NGUI a few frames to actually build/render the label meshes.
		for (int i = 0; i < 10; i++)
		{
			yield return null;
		}

		string path = System.IO.Path.Combine(Application.dataPath, "../../main_screenshot.png");
		path = System.IO.Path.GetFullPath(path);
		ScreenCapture.CaptureScreenshot(path);
		Debug.Log("[CaptureMainScreenshot] Screenshot requested at: " + path);

		yield return null;
		yield return null;
		yield return new WaitForSeconds(1f);

		Debug.Log("[CaptureMainScreenshot] SUCCESS: capture flow complete.");
	}
}
