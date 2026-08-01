using Artemis;
using Artemis.System;

namespace SSAR.BattleSystem.EntityTemplate
{
	// See HeroStateMachineComponent for why this exists. Mirrors MovementSystem.
	public class HeroStateMachineSystem : EntityProcessingSystemWithTime
	{
		public HeroStateMachineSystem(bool subscribeSimTime)
			: base(Aspect.All(typeof(HeroStateMachineComponent)), subscribeSimTime)
		{
		}

		protected override void Process(Entity entity, float deltaTime)
		{
			HeroStateMachineComponent component = entity.GetComponent<HeroStateMachineComponent>();
			if (component != null && component.heroStateMachine != null)
			{
				component.heroStateMachine.Update(deltaTime);
			}
		}
	}
}
