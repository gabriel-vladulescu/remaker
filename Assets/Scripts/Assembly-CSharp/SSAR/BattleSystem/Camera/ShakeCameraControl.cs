using Artemis;

namespace SSAR.BattleSystem.Camera
{
	public class ShakeCameraControl : AbsCameraControlData
	{
		private ShakeCameraData data;

		private bool isFinish;

		private CameraComponent cameraComponent;

		public ShakeCameraControl(CameraAccessLevel accessLevelLevel, ShakeCameraData data)
			: base(default(CameraAccessLevel))
		{
		}

		public override void Excute(Entity self)
		{
		}

		public override bool IsValid()
		{
			return false;
		}

		public override void Update(float deltaTime)
		{
		}

		public override bool Finished()
		{
			return false;
		}

		public override void OnExit()
		{
		}
	}
}
