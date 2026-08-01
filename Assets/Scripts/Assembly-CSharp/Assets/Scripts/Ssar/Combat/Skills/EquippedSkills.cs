using System.Collections.Generic;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	public class EquippedSkills
	{
		public class FindResult
		{
			private bool found;

			private EquippedSkill eq;

			public bool Found => false;

			public EquippedSkill Eq => null;

			public FindResult(bool found, EquippedSkill eq)
			{
			}
		}

		private List<EquippedSkill> combos;

		private EquippedSkill dash;

		private EquippedSkill dashAtk;

		private EquippedSkill jump;

		private EquippedSkill secondJump;

		private List<EquippedSkill> jumpAtks;

		private List<EquippedSkill> actives;

		private List<EquippedSkill> ancients;

		public void AddActive(EquippedSkill active)
		{
		}

		public void ChangeActiveSkill(EquippedSkill active, int index)
		{
		}

		public void AddCombo(EquippedSkill combo)
		{
		}

		public void AddDash(EquippedSkill dash)
		{
		}

		public void AddDashAtk(EquippedSkill dashAtk)
		{
		}

		public void AddJump(EquippedSkill jump)
		{
		}

		public void Add2ndJump(EquippedSkill jump)
		{
		}

		public void AddJumpAtk(EquippedSkill jumpAtk)
		{
		}

		public void AddAncient(EquippedSkill ancient)
		{
		}

		private void CheckValidJumpOrder(int order)
		{
		}

		public EquippedSkill GetCombo(int order)
		{
			return null;
		}

		public EquippedSkill GetDash()
		{
			return null;
		}

		public EquippedSkill GetDashAtk()
		{
			return null;
		}

		public EquippedSkill GetJump()
		{
			return null;
		}

		public EquippedSkill Get2ndJump()
		{
			return null;
		}

		public EquippedSkill GetJumpAtk(int order)
		{
			return null;
		}

		public EquippedSkill GetActive(int order)
		{
			return null;
		}

		public EquippedSkill GetAncient(int order)
		{
			return null;
		}

		public int GetActiveCount()
		{
			return 0;
		}

		public int GetAncientCount()
		{
			return 0;
		}

		public int ComboCount()
		{
			return 0;
		}

		private void CheckValidComboOrder(int order)
		{
		}
	}
}
