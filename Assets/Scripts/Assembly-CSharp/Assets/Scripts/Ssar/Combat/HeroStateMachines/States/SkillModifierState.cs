using System;
using Assets.Scripts.Core.FiniteStateMachine;
using Assets.Scripts.Core.Skills;
using Checking;

namespace Assets.Scripts.Ssar.Combat.HeroStateMachines.States
{
	public class SkillModifierState : State
	{
		private UserInput userInput;

		private Animation animation;

		private Movement movement;

		private Event event_;

		private readonly Character character;

		private NotNullReference notNullReference;

		private bool isReturnToDefaultState;

		private Character.CharacterState currentState;

		private Character.CharacterState previousState;

		private bool isBeHitInTheAir;

		private bool isFallEnd;

		private bool listen;

		public SkillModifierState(UserInput userInput, Animation animation, Movement movement, Event @event, Character character)
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
