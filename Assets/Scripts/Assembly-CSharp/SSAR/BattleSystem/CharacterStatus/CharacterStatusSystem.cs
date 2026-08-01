using Artemis;
using Artemis.System;

namespace SSAR.BattleSystem.CharacterStatus
{
	public class CharacterStatusSystem : EntityProcessingSystemWithTime
	{
		public CharacterStatusSystem(bool subscribeSimTime)
			: base(null, subscribeSimTime: false)
		{
		}

		protected override void Process(Entity entity, float deltaTime)
		{
		}
	}
}
