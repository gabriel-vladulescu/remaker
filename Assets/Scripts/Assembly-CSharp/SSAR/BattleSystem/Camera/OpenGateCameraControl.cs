using Artemis;
using SSAR.BattleSystem.Movement;
using UnityEngine;

namespace SSAR.BattleSystem.Camera
{
	public class OpenGateCameraControl : AbsCameraControlData
	{
		private bool finish;

		private CharacterMediatorComponent mainCharacterMediatorComponent;

		private CameraComponent cameraComponent;

		private AnimationCurve animationCurve;

		private float time;

		private float duration;

		private float targetPos;

		private float originalPos;

		private float extend;

		public OpenGateCameraControl(CameraAccessLevel accessLevelLevel)
			: base(default(CameraAccessLevel))
		{
		}

		public override void Excute(Entity self)
		{
		}

		public override void Update(float deltaTime)
		{
		}

		public override bool Finished()
		{
			return false;
		}

		private bool IsInleftCamera()
		{
			return false;
		}

		public override void OnExit()
		{
		}

		private void SetNewBoundary(float pos)
		{
		}
	}
}
