using System;
using Assets.Scripts.Core.FiniteStateMachine;
using Assets.Scripts.Core.Skills;
using Checking;

namespace Assets.Scripts.Ssar.Combat.HeroStateMachines.States
{
	public class JumpAttack1State : State
	{
		public interface JumpAttack1StateMovement
		{
			void OnInputRun();

			void OnAnimationEnd();

			void OnStateEnter();

			void OnStateExit();
		}

		private class DefaultJumpAttack1StateMovement : JumpAttack1StateMovement
		{
			private Movement movement;

			public DefaultJumpAttack1StateMovement(Movement movement)
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

		private UserInput userInput;

		private Animation animation;

		private Movement movement;

		private Event event_;

		private Hero hero;

		private Character character;

		private string skillId;

		private readonly ComboAttackState.AnimationFrame animationFrame;

		private readonly ComboAttackState.IgnoreInputWindow ignoreInputWindow;

		private JumpAttack1StateMovement jumpAttack1StateMovement;

		private NotNullReference notNullReference;

		private bool isAnimationEnd;

		private bool isAttackInputAcceptable;

		private bool isAttackInputRecognized;

		private float elapsed;

		private bool isRunInputRecognized;

		private bool isDashInputRecognized;

		private ComboAttackState.AcceptInputWindow attackAcceptInputWindow;

		private bool isActiveFrameEnd;

		private int elapsedFrames;

		private bool isFallEnd;

		public JumpAttack1State(UserInput userInput, Animation animation, Movement movement, Event event_, Hero hero, Character character, string skillId, ComboAttackState.AnimationFrame animationFrame, ComboAttackState.IgnoreInputWindow ignoreInputWindow, JumpAttack1StateMovement ja1sm = null)
		{
		}

		public string Name()
		{
			return null;
		}

		public void Execute(float dt, StateMachine stateMachine)
		{
		}

		protected virtual bool IsNextAttackAvailable()
		{
			return false;
		}

		public void Enter(bool resume, string fromStateName)
		{
		}

		public void Exit()
		{
		}

		private void OnFallEnd(object source, EventArgs args)
		{
		}
	}
}
