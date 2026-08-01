using System;
using Assets.Scripts.Core.FiniteStateMachine;
using Assets.Scripts.Core.Skills;
using Assets.Scripts.Ssar.Combat.HeroStateMachines.States;
using Assets.Scripts.Ssar.Combat.Skills;
using Checking;

namespace Assets.Scripts.Ssar.Combat.HeroStateMachines
{
	public class Character2StateMachine : HeroStateMachine
	{
		protected new UserInput userInput;

		protected new Animation animation;

		protected new Movement movement;

		protected new Event event_;

		protected new Hero hero;

		protected new Character character;

		private new EquippedSkills equippedSkills;

		protected new NotNullReference notNullReference;

		protected new StateMachine stateMachine;

		public Character2StateMachine(UserInput userInput, Animation animation, Movement movement, Event event_, Hero hero, Character character, EquippedSkills equippedSkills)
			: base(null, null, null, null, null, null, null)
		{
		}

		public override void ListenToStateTransition(Action<string, string, bool> action)
		{
		}

		public override void ListenToPreStateTransition(Action<string, string, bool> action)
		{
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

		protected new virtual void DefineStates(UserInput userInput, Animation animation, Movement movement, SpawnState spawnState)
		{
		}

		protected new virtual void DefineTransitions()
		{
		}
	}
}
