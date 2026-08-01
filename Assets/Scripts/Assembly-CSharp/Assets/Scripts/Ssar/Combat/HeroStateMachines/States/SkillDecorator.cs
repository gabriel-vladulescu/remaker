using System.Collections.Generic;
using Assets.Scripts.Core.FiniteStateMachine;
using Assets.Scripts.Core.Skills;
using Assets.Scripts.Ssar.Combat.Skills;
using Checking;

namespace Assets.Scripts.Ssar.Combat.HeroStateMachines.States
{
	public class SkillDecorator : State
	{
		public class WhiteList
		{
			private bool any;

			private List<string> skillIds;

			public static WhiteList Any()
			{
				return null;
			}

			public static WhiteList One(string skillId)
			{
				return null;
			}

			public static WhiteList None()
			{
				return null;
			}

			public bool Contains(string skillId)
			{
				return false;
			}
		}

		private static string[] STATE_NAMES;

		private State origin;

		private UserInput userInput;

		private Character character;

		private EquippedSkills equippedSkills;

		private WhiteList whiteList;

		public bool log;

		private NotNullReference notNullReference;

		public SkillDecorator(State origin, UserInput userInput, Character character, WhiteList whiteList = null, EquippedSkills equippedSkills = null)
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
	}
}
