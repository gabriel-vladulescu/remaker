using Artemis;
using SSAR.BattleSystem.System.Input.Model;
using UnityEngine;

namespace Assets.Scripts.Ssar.Dungeon.Environment
{
	// Drives the Artemis EntityWorld each frame for the real Dungeon scene.
	// Not part of the original game; InitDungeonSystemCmd is a StrangeIoC
	// Command that runs once, so something needs to tick entityWorld.Update()
	// every frame. Mirrors the manual Update() loop used by the Phase 6
	// validation harnesses (MovementValidationHarness / RealCharacterValidationHarness).
	//
	// Also spawns a placeholder camera + ground plane. Dungeon.unity itself
	// contains only a single empty "DungeonContext" GameObject - the real
	// game builds the entire level (terrain, camera, gates) procedurally at
	// runtime via Dungeon/DungeonFactory/DefaultStage/DefaultEnvironment/
	// CameraComponent, which are all still fully stub (a much bigger
	// reimplementation effort than movement/input testing needs). This is
	// just enough to make the spawned character visible for interactive
	// testing, not a real level.
	public class DungeonSimulationDriver : MonoBehaviour
	{
		private EntityWorld entityWorld;
		private CharacterInput mainCharacterInput;
		private Transform cameraTarget;
		private Camera placeholderCamera;
		private static readonly Vector3 CameraOffset = new Vector3(0f, 3f, -8f);

		public void Init(EntityWorld entityWorld, CharacterInput mainCharacterInput, Transform cameraTarget)
		{
			this.entityWorld = entityWorld;
			this.mainCharacterInput = mainCharacterInput;
			this.cameraTarget = cameraTarget;
			UnityEngine.Object.DontDestroyOnLoad(gameObject);

			SpawnPlaceholderGround();
			SpawnPlaceholderCamera();
			SpawnPlaceholderLight();
		}

		private void SpawnPlaceholderGround()
		{
			GameObject ground = GameObject.CreatePrimitive(PrimitiveType.Plane);
			ground.name = "PlaceholderGround";
			ground.transform.localScale = new Vector3(20f, 1f, 20f);
			ground.transform.position = Vector3.zero;

			// Unity's default Plane material is a light gray that washes out
			// close to white under the placeholder directional light below;
			// give it an explicit muted color instead of relying on that default.
			Renderer renderer = ground.GetComponent<Renderer>();
			if (renderer != null)
			{
				renderer.material.color = new Color(0.3f, 0.35f, 0.3f);
			}
		}

		// Steps aside if a real 3D-world camera already exists (e.g. carried
		// into this scene by the real boot chain via DontDestroyOnLoad, or
		// provided by a real CameraComponent/DungeonFactory once that system
		// exists), rather than fighting it for the MainCamera tag.
		private void SpawnPlaceholderCamera()
		{
			if (Camera.main != null)
			{
				return;
			}
			GameObject camGo = new GameObject("PlaceholderMainCamera");
			camGo.tag = "MainCamera";
			placeholderCamera = camGo.AddComponent<Camera>();
			placeholderCamera.clearFlags = CameraClearFlags.SolidColor;
			placeholderCamera.backgroundColor = new Color(0.4f, 0.6f, 0.9f);
			UpdateCameraPosition();
		}

		private void SpawnPlaceholderLight()
		{
			// Dungeon.unity has no light source at all. Standard/PBR-lit
			// character materials (e.g. 1_1_body_Material, which has
			// Glossiness/Metallic/rim-light properties) render as a flat
			// white silhouette under ambient-only lighting with no
			// directional key light - this fixes that for testing purposes.
			// Steps aside if a real light already exists in the scene.
			if (UnityEngine.Object.FindObjectOfType<Light>() != null)
			{
				return;
			}
			GameObject lightGo = new GameObject("PlaceholderDirectionalLight");
			Light light = lightGo.AddComponent<Light>();
			light.type = LightType.Directional;
			light.intensity = 1f;
			light.shadows = LightShadows.None;
			lightGo.transform.rotation = Quaternion.Euler(50f, -30f, 0f);
		}

		private void UpdateCameraPosition()
		{
			if (placeholderCamera == null || cameraTarget == null)
			{
				return;
			}
			placeholderCamera.transform.position = cameraTarget.position + CameraOffset;
			placeholderCamera.transform.LookAt(cameraTarget.position + Vector3.up);
		}

		private void Update()
		{
			if (entityWorld == null)
			{
				return;
			}

			entityWorld.Update((long)(Time.deltaTime * global::System.TimeSpan.TicksPerSecond));

			if (mainCharacterInput != null)
			{
				mainCharacterInput.ReleaseInputJump();
				mainCharacterInput.ReleaseInputDash();
			}
		}

		private void LateUpdate()
		{
			UpdateCameraPosition();
		}
	}
}
