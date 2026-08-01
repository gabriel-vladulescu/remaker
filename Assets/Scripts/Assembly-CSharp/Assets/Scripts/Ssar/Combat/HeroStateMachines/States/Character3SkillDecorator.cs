using Assets.Scripts.Core.FiniteStateMachine;
using Assets.Scripts.Core.Skills;

namespace Assets.Scripts.Ssar.Combat.HeroStateMachines.States
{
	public class Character3SkillDecorator : State
	{
		private static string ARCANE_DASH_SKILL_ID;

		private static string ARCANE_RAY_SKILL_ID;

		private static string ARCANE_BLAST_SKILL_ID;

		private State origin;

		private UserInput userInput;

		private Character character;

		private bool isArcaneBlastSkillOngoing;

		private bool isArcaneBlastJustFinishChanneling;

		public Character3SkillDecorator(State origin, UserInput userInput, Character character)
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
