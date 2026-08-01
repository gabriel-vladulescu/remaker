using Artemis;
using Artemis.System;

namespace SSAR.BattleSystem.Camera
{
	public class CameraSystem : EntityProcessingSystemWithTime
	{
		public CameraSystem(bool subscribeSimTime)
			: base(null, subscribeSimTime: false)
		{
		}

		protected override void Process(Entity entity, float deltaTime)
		{
		}

		private void ProcessQueue(Entity entity)
		{
		}

		private bool IsValid(AbsCameraControlData current, AbsCameraControlData next)
		{
			return false;
		}

		private AbsCameraControlData GetDefaultCameraRemote(CameraComponent camera)
		{
			return null;
		}
	}
}
