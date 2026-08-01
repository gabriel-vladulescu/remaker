using Artemis;
using Artemis.System;

namespace SSAR.BattleSystem.Gizmo
{
	public class GizmoDrawSystem : EntityProcessingSystemWithTime
	{
		public GizmoDrawSystem(bool subscribeSimTime)
			: base(null, subscribeSimTime: false)
		{
		}

		protected override void Process(Entity entity, float deltaTime)
		{
		}
	}
}
