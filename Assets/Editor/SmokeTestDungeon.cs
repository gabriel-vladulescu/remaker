using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

public static class SmokeTestDungeon
{
	public static void Run()
	{
		EditorSceneManager.OpenScene("Assets/Scenes/Build/Dungeon.unity");
		Debug.Log("[SmokeTestDungeon] Scene opened, entering play mode...");
		EditorApplication.isPlaying = true;
	}
}
