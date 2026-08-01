using Assets.Scripts.PhaseValidation;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class SetupValidationScene
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
		Camera camComp = cam.AddComponent<Camera>();
		cam.tag = "MainCamera";
		cam.transform.position = new Vector3(0f, 3f, -8f);
		cam.transform.LookAt(new Vector3(0f, 1f, 0f));

		GameObject harnessGo = new GameObject("MovementValidationHarness");
		harnessGo.transform.position = new Vector3(0f, 1f, 0f);
		harnessGo.AddComponent<MovementValidationHarness>();

		EditorSceneManager.SaveScene(scene, "Assets/Scenes/_PhaseValidation/MovementValidation.unity");
		Debug.Log("[SetupValidationScene] Scene created and saved at Assets/Scenes/_PhaseValidation/MovementValidation.unity");
	}
}
