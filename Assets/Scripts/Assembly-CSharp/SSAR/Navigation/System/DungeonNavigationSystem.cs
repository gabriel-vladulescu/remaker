using Artemis;
using Artemis.System;

namespace SSAR.Navigation.System
{
	public class DungeonNavigationSystem : EntityProcessingSystemWithTime
	{
		private Entity cameraEntity;

		private bool isClearStage;

		public DungeonNavigationSystem(bool subscribeSimTime)
			: base(null, subscribeSimTime: false)
		{
		}

		private void OnEnterStage(int stageOrder)
		{
		}

		private void OnClearStage(int stageOrder)
		{
		}

		protected override void Process(Entity entity, float deltaTime)
		{
		}

		private Entity GetCameraEntity()
		{
			return null;
		}

		private void CheckPosition(Entity camera, Entity monster)
		{
		}

		public override void OnRemoved(Entity entity)
		{
		}
	}
}
