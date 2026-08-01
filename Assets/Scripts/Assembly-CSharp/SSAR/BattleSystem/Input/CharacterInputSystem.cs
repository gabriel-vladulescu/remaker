using Artemis;
using Artemis.System;

namespace SSAR.BattleSystem.Input
{
	public class CharacterInputSystem : EntityProcessingSystemWithTime
	{
		public CharacterInputSystem(bool subscribeSimTime)
			: base(null, subscribeSimTime: false)
		{
		}

		protected override void Process(Entity entity, float deltaTime)
		{
		}
	}
}
