using System.Collections.Generic;
using Assets.Scripts.Ssar.Combat.HeroStateMachines;

namespace Assets.Scripts.Core.Skills
{
	internal class TestUserInput : UserInput
	{
		private bool isInputRun;

		private bool isInputDash;

		private bool isInputJump;

		private bool isInputAttack;

		private bool isInputSkill;

		private bool[] isInputSkills;

		private string[] skillIds;

		private List<string> skills;

		public TestUserInput(List<string> skills)
		{
		}

		public virtual void Update(float dt)
		{
		}

		public virtual bool IsInputRunInOppositeDirection()
		{
			return false;
		}

		public virtual void LateUpdate()
		{
		}

		public virtual void CastSkill(int skillOrder, string skillId)
		{
		}

		public virtual void ReleaseCastSkill(int skillOrder)
		{
		}

		public virtual bool IsInputRun()
		{
			return false;
		}

		public virtual bool IsInputDash()
		{
			return false;
		}

		public virtual bool IsInputJump()
		{
			return false;
		}

		public virtual bool IsInputAttack()
		{
			return false;
		}

		public virtual bool IsInputSkill()
		{
			return false;
		}

		public virtual string SkillId()
		{
			return null;
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
