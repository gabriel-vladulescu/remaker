using System;
using Assets.Scripts.Core.FiniteStateMachine;
using Assets.Scripts.Core.Skills;
using Checking;

namespace Assets.Scripts.Ssar.Combat.HeroStateMachines.States
{
	public class SkillModifierDecorator : State
	{
		private State origin;

		private readonly Character character;

		private Event event_;

		private bool isReplaceCurrentState;

		private NotNullReference notNullReference;

		private bool isModifierTriggered;

		private Character.CharacterState characterState;

		public SkillModifierDecorator(State origin, Character character, Event @event, bool isReplaceCurrentState = true)
		{
		}

		public string Name()
		{
			return null;
		}

		public void Execute(float dt, StateMachine stateMachine)
		{
		}

		public void Enter(bool resume, string fromStateName)
		{
		}

		public void Exit()
		{
		}

		private void OnModifierState(object source, EventArgs args)
		{
		}
	}
}
