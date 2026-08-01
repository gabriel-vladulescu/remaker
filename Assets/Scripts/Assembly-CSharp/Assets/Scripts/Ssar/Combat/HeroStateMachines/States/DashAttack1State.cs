using System;
using Assets.Scripts.Core.FiniteStateMachine;
using Assets.Scripts.Core.Skills;
using Checking;

namespace Assets.Scripts.Ssar.Combat.HeroStateMachines.States
{
	public class DashAttack1State : State
	{
		private UserInput userInput;

		private Animation animation;

		private Movement movement;

		private Event event_;

		private Hero hero;

		private Character character;

		private string skillId;

		private readonly ComboAttackState.AnimationFrame animationFrame;

		private float elapsed;

		private NotNullReference notNullReference;

		private bool isAnimationEnd;

		private bool isDamageDealingFrame;

		private bool isDamageDealt;

		private bool isRunInputRecognized;

		private bool isJumpInputRecognized;

		public DashAttack1State(UserInput userInput, Animation animation, Movement movement, Event event_, Hero hero, Character character, string skillId, ComboAttackState.AnimationFrame animationFrame)
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

		private void OnAnimationEnd(object source, EventArgs args)
		{
		}
	}
}
