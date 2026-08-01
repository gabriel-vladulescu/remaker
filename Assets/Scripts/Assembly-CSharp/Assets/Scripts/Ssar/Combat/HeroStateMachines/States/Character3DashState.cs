using System;
using Assets.Scripts.Core.FiniteStateMachine;
using Assets.Scripts.Core.Skills;
using Checking;

namespace Assets.Scripts.Ssar.Combat.HeroStateMachines.States
{
	public class Character3DashState : State
	{
		private UserInput userInput;

		private Animation animation;

		private Movement movement;

		private Event event_;

		private Hero hero;

		private Character character;

		private string skillId;

		private readonly ComboAttackState.AnimationFrame af;

		private ComboAttackState.IgnoreInputWindow ignoreInputWindow;

		private NotNullReference notNullReference;

		private float elapsed;

		private bool isDashBrake;

		private bool isAttackInputRecognized;

		private string fromStateName;

		public Character3DashState(UserInput userInput, Animation animation, Movement movement, Event event_, Hero hero, Character character, string skillId, ComboAttackState.AnimationFrame af, ComboAttackState.IgnoreInputWindow ignoreInputWindow)
		{
		}

		public string Name()
		{
			return null;
		}

		public void Execute(float dt, StateMachine stateMachine)
		{
		}

		private bool IsFromJumpFallState()
		{
			return false;
		}

		public void Enter(bool resume, string fromStateName)
		{
		}

		public void Exit()
		{
		}

		private void OnDashEnd(object source, EventArgs args)
		{
		}
	}
}
