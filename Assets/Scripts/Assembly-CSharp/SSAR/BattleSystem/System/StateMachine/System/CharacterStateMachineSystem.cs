using Artemis;
using Artemis.System;

namespace SSAR.BattleSystem.System.StateMachine.System
{
	public class CharacterStateMachineSystem : EntityProcessingSystemWithTime
	{
		public bool enableUpdate;

		private int frame;

		public CharacterStateMachineSystem(bool subscribeSimTime)
			: base(null, subscribeSimTime: false)
		{
		}

		public override void Process()
		{
		}

		protected override void Process(Entity entity, float deltaTime)
		{
		}
	}
}
