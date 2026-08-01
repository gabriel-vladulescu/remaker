using System;
using Assets.Scripts.Core.FiniteStateMachine;
using Assets.Scripts.Core.Skills;

namespace Assets.Scripts.Ssar.Combat.HeroStateMachines.States
{
	public class SkillState : State
	{
		private UserInput userInput;

		private Character character;

		private Event event_;

		private Movement movement;

		private ComboAttackState.IgnoreInputWindow ignoreInputWindow;

		private bool isModifierAdded;

		private float elapsed;

		private Skill skill;

		private string skillId;

		private Character.CharacterState currentState;

		private bool isStateChangedToModifier;

		public SkillState(UserInput userInput, Character character, Event @event, Movement movement)
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

		private void OnFallEnd(object source, EventArgs args)
		{
		}
	}
}
