using Assets.Scripts.Core.Skills;
using Assets.Scripts.Ssar.Combat.HeroStateMachines;
using Assets.Scripts.Ssar.Combat.HeroStateMachines.States;

namespace Assets.Scripts.Ssar.Combat.MonsterStateMachines
{
	public class MonsterStateMachine : HeroStateMachine
	{
		public MonsterStateMachine(UserInput userInput, Animation animation, Movement movement, Event @event, Hero hero, Character character)
			: base(null, null, null, null, null, null, null)
		{
		}

		protected override bool Debug()
		{
			return false;
		}

		protected override void DefineStates(UserInput userInput, Animation animation, Movement movement, SpawnState spawnState)
		{
		}

		protected override void DefineTransitions()
		{
		}
	}
}
