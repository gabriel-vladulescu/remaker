using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

public static class SmokeTestBootChain
{
	public static void Run()
	{
		EditorSceneManager.OpenScene("Assets/Scenes/Build/EntryScene.unity");
		Debug.Log("[SmokeTestBootChain] EntryScene opened, entering play mode...");
		EditorApplication.isPlaying = true;
	}
}
