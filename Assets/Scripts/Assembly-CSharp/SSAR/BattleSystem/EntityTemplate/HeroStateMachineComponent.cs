using Artemis.Interface;
using Assets.Scripts.Ssar.Combat.HeroStateMachines;

namespace SSAR.BattleSystem.EntityTemplate
{
	// Not part of the original decompiled game (no such component/wrapper was
	// found anywhere in the reconstructed codebase). HeroStateMachine itself
	// isn't an Artemis IComponent, but something needs to tick its Update()
	// every frame once it's attached to a spawned entity, so this follows the
	// same Component+System pattern already used for MovementComponent/System.
	public class HeroStateMachineComponent : IComponent
	{
		public HeroStateMachine heroStateMachine;

		public HeroStateMachineComponent(HeroStateMachine heroStateMachine)
		{
			this.heroStateMachine = heroStateMachine;
		}
	}
}
