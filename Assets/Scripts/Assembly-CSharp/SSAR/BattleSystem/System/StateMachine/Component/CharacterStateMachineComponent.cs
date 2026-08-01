using Artemis.Interface;
using Assets.Scripts.Ssar.Combat.HeroStateMachines;

namespace SSAR.BattleSystem.System.StateMachine.Component
{
	public class CharacterStateMachineComponent : IComponent
	{
		public HeroStateMachine HeroStateMachine;

		private bool enable;

		public CharacterStateMachineComponent(HeroStateMachine heroStateMachine)
		{
		}

		public void Update(float deltaTime)
		{
		}

		public void SetEnable(bool enable)
		{
		}

		public string GetCurrentStateName()
		{
			return null;
		}
	}
}
