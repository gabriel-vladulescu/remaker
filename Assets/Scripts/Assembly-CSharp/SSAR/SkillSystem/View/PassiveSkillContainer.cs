using System.Collections.Generic;
using Scripts.Config;

namespace SSAR.SkillSystem.View
{
	public class PassiveSkillContainer : AbsSkillContainer
	{
		private List<ISkillStat> row1;

		private List<ISkillStat> row2;

		private List<ISkillStat> row3;

		public UITexture line1;

		public UITexture line2;

		public UITexture line3;

		protected override void OnShow(MainCharacterData mainCharacterData)
		{
		}

		private void UpdateLineSize(int numOfElement, UITexture line)
		{
		}

		protected override List<ISkillStat> Row1SkillList(MainCharacterData mainCharacterData)
		{
			return null;
		}

		protected override List<ISkillStat> Row2SkillList(MainCharacterData mainCharacterData)
		{
			return null;
		}

		protected override List<ISkillStat> Row3SkillList(MainCharacterData mainCharacterData)
		{
			return null;
		}

		protected override ISkillStat GetCurrentSkillStat(MainCharacterData mainCharacterData, int curSkillId)
		{
			return null;
		}

		protected override int GetCurrentLevel(MainCharacterData mainCharacterData, ISkillStat skillStat, Preset preset)
		{
			return 0;
		}

		protected override bool IsMaxLevel(ISkillStat skillStat, int level)
		{
			return false;
		}

		protected override string GetDescription(ISkillStat skillStat)
		{
			return null;
		}

		protected override double GetValueInVisual(ISkillStat skillStat, int level)
		{
			return 0.0;
		}
	}
}
