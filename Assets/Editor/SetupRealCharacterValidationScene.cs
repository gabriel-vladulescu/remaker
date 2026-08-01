using Assets.Scripts.PhaseValidation;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class SetupRealCharacterValidationScene
{
	public static void Run()
	{
		Scene scene = EditorSceneManager.NewScene(NewSceneSetup.EmptyScene, NewSceneMode.Single);

		GameObject ground = GameObject.CreatePrimitive(PrimitiveType.Plane);
		ground.name = "Ground";
		ground.transform.position = Vector3.zero;
		ground.transform.localScale = new Vector3(5f, 1f, 5f);

		GameObject light = new GameObject("Directional Light");
		Light lightComp = light.AddComponent<Light>();
		lightComp.type = LightType.Directional;
		light.transform.rotation = Quaternion.Euler(50f, -30f, 0f);

		GameObject cam = new GameObject("Main Camera");
		cam.AddComponent<Camera>();
		cam.tag = "MainCamera";
		cam.transform.position = new Vector3(0f, 2f, -6f);
		cam.transform.LookAt(new Vector3(0f, 1f, 0f));

		GameObject harnessGo = new GameObject("RealCharacterValidationHarness");
		harnessGo.transform.position = new Vector3(0f, 1f, 0f);
		harnessGo.AddComponent<RealCharacterValidationHarness>();

		EditorSceneManager.SaveScene(scene, "Assets/Scenes/_PhaseValidation/RealCharacterValidation.unity");
		Debug.Log("[SetupRealCharacterValidationScene] Scene created and saved.");
	}
}
