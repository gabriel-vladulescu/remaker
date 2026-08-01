using Artemis;
using Artemis.System;

namespace SSAR.BattleSystem.System
{
	public class EntitySuicideSystem : EntityProcessingSystemWithTime
	{
		public EntitySuicideSystem(bool subscribeSimTime)
			: base(null, subscribeSimTime: false)
		{
		}

		protected override void Process(Entity entity, float deltaTime)
		{
		}
	}
}
