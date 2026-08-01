using System.Collections;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;

// Drives the boot chain all the way from EntryScene through to
// SelectionScene, simulating the button clicks a real player would make
// (tap-to-play, guest login, adventure) via UICamera.Notify - NGUI's own
// SendMessage-based event dispatch, so this exercises the exact same code
// path a real click would. Not part of the original game.
//
// The driver has to be a runtime MonoBehaviour rather than editor-side
// EditorApplication.update state: entering Play mode triggers a domain
// reload, which wipes any editor-side event subscriptions registered
// beforehand. SessionState survives the reload and is used purely as the
// "should I spawn the driver" flag.
public static class SmokeTestFullFlow
{
	private const string ActiveKey = "SmokeTestFullFlow_Active";

	public static void Run()
	{
		EditorSceneManager.OpenScene("Assets/Scenes/Build/EntryScene.unity");
		Debug.Log("[SmokeTestFullFlow] EntryScene opened, entering play mode...");
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

		GameObject driverGo = new GameObject("SmokeTestFullFlowDriver");
		Object.DontDestroyOnLoad(driverGo);
		driverGo.AddComponent<SmokeTestFullFlowDriver>();
	}
}

public class SmokeTestFullFlowDriver : MonoBehaviour
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
				Debug.LogError("[SmokeTestFullFlow] Timed out waiting for TitleScene.");
				yield break;
			}
			yield return null;
		}
		Debug.Log("[SmokeTestFullFlow] Reached TitleScene.");
		yield return null;
		yield return null;

		TitleSceneView titleView = Object.FindObjectOfType<TitleSceneView>();
		if (titleView == null)
		{
			Debug.LogError("[SmokeTestFullFlow] Could not find TitleSceneView instance.");
			yield break;
		}
		if (titleView.clickArea == null)
		{
			Debug.LogError("[SmokeTestFullFlow] TitleSceneView.clickArea is unassigned.");
			yield break;
		}
		UICamera.Notify(titleView.clickArea, "OnClick", null);
		Debug.Log("[SmokeTestFullFlow] Clicked clickArea (tap to play).");
		yield return null;
		yield return null;

		if (titleView.btn_loginGuest == null)
		{
			Debug.LogError("[SmokeTestFullFlow] TitleSceneView.btn_loginGuest is unassigned.");
			yield break;
		}
		UICamera.Notify(titleView.btn_loginGuest, "OnClick", null);
		Debug.Log("[SmokeTestFullFlow] Clicked btn_loginGuest.");

		timeout = Time.realtimeSinceStartup + 15f;
		while (SceneManager.GetActiveScene().name != "Main")
		{
			if (Time.realtimeSinceStartup > timeout)
			{
				Debug.LogError("[SmokeTestFullFlow] Timed out waiting for Main scene.");
				yield break;
			}
			yield return null;
		}
		Debug.Log("[SmokeTestFullFlow] Reached Main scene.");
		yield return null;
		yield return null;
		yield return null;

		MainScenePopup mainPopup = Object.FindObjectOfType<MainScenePopup>();
		if (mainPopup == null)
		{
			Debug.LogError("[SmokeTestFullFlow] Could not find MainScenePopup instance in Main scene.");
			yield break;
		}
		if (mainPopup.btn_adventure == null)
		{
			Debug.LogError("[SmokeTestFullFlow] MainScenePopup.btn_adventure is unassigned.");
			yield break;
		}
		UICamera.Notify(mainPopup.btn_adventure, "OnClick", null);
		Debug.Log("[SmokeTestFullFlow] Clicked btn_adventure.");

		timeout = Time.realtimeSinceStartup + 15f;
		while (SceneManager.GetActiveScene().name != "SelectionScene")
		{
			if (Time.realtimeSinceStartup > timeout)
			{
				Debug.LogError("[SmokeTestFullFlow] Timed out waiting for SelectionScene.");
				yield break;
			}
			yield return null;
		}
		Debug.Log("[SmokeTestFullFlow] SUCCESS: reached SelectionScene via full click-through flow.");
	}
}
