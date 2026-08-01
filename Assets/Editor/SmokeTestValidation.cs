using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

public static class SmokeTestValidation
{
	public static void Run()
	{
		EditorSceneManager.OpenScene("Assets/Scenes/_PhaseValidation/RealCharacterValidation.unity");
		Debug.Log("[SmokeTest] Scene opened, entering play mode...");
		EditorApplication.isPlaying = true;
	}
}
