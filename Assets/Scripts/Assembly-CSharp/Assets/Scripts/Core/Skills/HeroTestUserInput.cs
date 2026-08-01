using System.Collections.Generic;

namespace Assets.Scripts.Core.Skills
{
	internal class HeroTestUserInput : TestUserInput
	{
		private bool isInputRun;

		private bool isInputDash;

		private bool isInputJump;

		private bool isInputAttack;

		private bool isInputSkill;

		private bool[] isInputSkills;

		private string[] skillIds;

		private List<string> skills;

		public HeroTestUserInput(List<string> skills)
			: base(null)
		{
		}

		public override void Update(float dt)
		{
		}

		public override bool IsInputRunInOppositeDirection()
		{
			return false;
		}

		public override void LateUpdate()
		{
		}

		public override void CastSkill(int skillOrder, string skillId)
		{
		}

		public override void ReleaseCastSkill(int skillOrder)
		{
		}

		public override bool IsInputRun()
		{
			return false;
		}

		public override bool IsInputDash()
		{
			return false;
		}

		public override bool IsInputJump()
		{
			return false;
		}

		public override bool IsInputAttack()
		{
			return false;
		}

		public override bool IsInputSkill()
		{
			return false;
		}

		public override string SkillId()
		{
			return null;
		}
	}
}
