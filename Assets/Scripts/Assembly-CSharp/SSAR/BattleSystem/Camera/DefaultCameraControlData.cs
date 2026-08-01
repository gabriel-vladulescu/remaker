using Artemis;

namespace SSAR.BattleSystem.Camera
{
	public class DefaultCameraControlData : AbsCameraControlData
	{
		private CameraComponent cameraComponent;

		public DefaultCameraControlData(CameraAccessLevel accessLevelLevel)
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

		public override void OnExit()
		{
		}
	}
}
