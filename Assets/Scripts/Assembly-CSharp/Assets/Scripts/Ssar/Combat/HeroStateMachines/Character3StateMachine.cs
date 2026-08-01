using System;
using Assets.Scripts.Core.FiniteStateMachine;
using Assets.Scripts.Core.Skills;
using Assets.Scripts.Ssar.Combat.HeroStateMachines.States;
using Assets.Scripts.Ssar.Combat.Skills;
using Checking;

namespace Assets.Scripts.Ssar.Combat.HeroStateMachines
{
	public class Character3StateMachine : HeroStateMachine
	{
		private class FloatJumpAttack1StateMovemment : JumpAttack1State.JumpAttack1StateMovement
		{
			private Movement movement;

			public FloatJumpAttack1StateMovemment(Movement movement)
			{
			}

			public void OnInputRun()
			{
			}

			public void OnAnimationEnd()
			{
			}

			public void OnStateEnter()
			{
			}

			public void OnStateExit()
			{
			}
		}

		protected new UserInput userInput;

		protected new Animation animation;

		protected new Movement movement;

		protected new Event event_;

		protected new Hero hero;

		protected new Character character;

		private new EquippedSkills equippedSkills;

		protected new NotNullReference notNullReference;

		protected new StateMachine stateMachine;

		public Character3StateMachine(UserInput userInput, Animation animation, Movement movement, Event @event, Hero hero, Character character, EquippedSkills equippedSkills)
			: base(null, null, null, null, null, null, null)
		{
		}

		public override void ListenToStateTransition(Action<string, string, bool> action)
		{
		}

		protected override bool Debug()
		{
			return false;
		}

		public override void Update(float dt)
		{
		}

		public override string GetCurrentStateName()
		{
			return null;
		}

		public override void ChangeToIdleState()
		{
		}

		protected override void DefineStates(UserInput userInput, Animation animation, Movement movement, SpawnState spawnState)
		{
		}

		protected override void DefineTransitions()
		{
		}
	}
}
