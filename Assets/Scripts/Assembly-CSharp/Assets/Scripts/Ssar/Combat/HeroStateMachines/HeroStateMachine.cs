using System;
using System.Collections.Generic;
using Assets.Scripts.Core.FiniteStateMachine;
using Assets.Scripts.Core.Skills;
using Assets.Scripts.Ssar.Combat.HeroStateMachines.States;
using Assets.Scripts.Ssar.Combat.Skills;
using Checking;

namespace Assets.Scripts.Ssar.Combat.HeroStateMachines
{
	public class HeroStateMachine
	{
		protected UserInput userInput;

		protected Animation animation;

		protected Movement movement;

		protected Event event_;

		protected Hero hero;

		protected Character character;

		protected EquippedSkills equippedSkills;

		protected NotNullReference notNullReference;

		protected StateMachine stateMachine;

		public HeroStateMachine(UserInput userInput, Animation animation, Movement movement, Event @event, Hero hero, Character character, EquippedSkills equippedSkills)
		{
			this.userInput = userInput;
			this.animation = animation;
			this.movement = movement;
			event_ = @event;
			this.hero = hero;
			this.character = character;
			this.equippedSkills = equippedSkills;

			SpawnState spawnState = new SpawnState(animation);
			DefineStates(userInput, animation, movement, spawnState);
			DefineTransitions();
		}

		protected HeroStateMachine()
		{
		}

		public virtual void ListenToStateTransition(Action<string, string, bool> action)
		{
			stateMachine.ListenToStateTransition(action);
		}

		public virtual void ListenToPreStateTransition(Action<string, string, bool> action)
		{
			stateMachine.ListenToPreStateTransition(action);
		}

		protected virtual bool Debug()
		{
			return false;
		}

		public virtual void Update(float dt)
		{
			stateMachine.Update(dt);
		}

		public virtual string GetCurrentStateName()
		{
			return stateMachine.GetCurrentStateName();
		}

		public virtual void ChangeToIdleState()
		{
			stateMachine.ReplaceCurrentStateBy(StateName.IDLE);
		}

		protected virtual void DefineStates(UserInput userInput, Animation animation, Movement movement, SpawnState spawnState)
		{
			stateMachine = new StateMachine(spawnState, Debug());
			stateMachine.DefineState(StateName.SPAWN, spawnState);
			stateMachine.DefineState(StateName.IDLE, new IdleState(userInput, animation, movement, hero));
			stateMachine.DefineState(StateName.RUN, new RunState(userInput, animation, movement, hero, character));
			stateMachine.DefineState(StateName.DASH, new DashState(userInput, animation, movement, event_, hero, character, null));
			stateMachine.DefineState(StateName.JUMP_FALL, new JumpFallState(userInput, animation, movement, event_, hero, character, null, null, 0, null, JumpToFallAnimationOffset()));
		}

		protected virtual void DefineTransitions()
		{
			stateMachine.DefineTransition(StateName.SPAWN, new List<string> { StateName.IDLE });
			stateMachine.DefineTransition(StateName.IDLE, new List<string> { StateName.RUN, StateName.DASH, StateName.JUMP_FALL, StateName.COMBO_ATTACK_1 });
			stateMachine.DefineTransition(StateName.RUN, new List<string> { StateName.IDLE, StateName.DASH, StateName.JUMP_FALL, StateName.COMBO_ATTACK_1 });
		}

		protected virtual float JumpToFallAnimationOffset()
		{
			return 0f;
		}

		protected virtual SkillDecorator.WhiteList WhiteList()
		{
			return null;
		}
	}
}
