using Assets.Scripts.Ssar.Combat.HeroStateMachines;

namespace Assets.UnitTest.Scripts.Ssar.Combat
{
	internal class TestUserInput : UserInput
	{
		private bool isInputRun;

		private bool isInputDash;

		private bool isInputJump;

		private bool isInputAttack;

		private bool isInputSkill;

		public void Update(float dt)
		{
		}

		public void LateUpdate()
		{
		}

		public bool IsInputRun()
		{
			return false;
		}

		public bool IsInputDash()
		{
			return false;
		}

		public bool IsInputJump()
		{
			return false;
		}

		public bool IsInputAttack()
		{
			return false;
		}

		public bool IsInputSkill()
		{
			return false;
		}

		public string SkillId()
		{
			return null;
		}

		public bool IsInputRunInOppositeDirection()
		{
			return false;
		}

		public void OnSkillCastingRequestConsumed()
		{
		}

		public bool IsHoldingAttack()
		{
			return false;
		}
	}
}
