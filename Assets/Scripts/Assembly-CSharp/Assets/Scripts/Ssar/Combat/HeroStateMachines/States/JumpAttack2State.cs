using System;
using Assets.Scripts.Core.FiniteStateMachine;
using Assets.Scripts.Core.Skills;
using Checking;

namespace Assets.Scripts.Ssar.Combat.HeroStateMachines.States
{
	public class JumpAttack2State : State
	{
		private UserInput userInput;

		private Animation animation;

		private Movement movement;

		private Event event_;

		private Hero hero;

		private Character character;

		private string skillId;

		private readonly ComboAttackState.AnimationFrame animationFrame;

		private NotNullReference notNullReference;

		private bool isFallEnd;

		private float elapsed;

		public JumpAttack2State(UserInput userInput, Animation animation, Movement movement, Event event_, Hero hero, Character character, string skillId, ComboAttackState.AnimationFrame animationFrame)
		{
		}

		public string Name()
		{
			return null;
		}

		public virtual void Execute(float dt, StateMachine stateMachine)
		{
		}

		public void Enter(bool resume, string fromStateName)
		{
		}

		public void Exit()
		{
		}

		protected float Elapsed()
		{
			return 0f;
		}

		protected bool IsFallEnd()
		{
			return false;
		}

		private void OnFallEnd(object source, EventArgs args)
		{
		}
	}
}
