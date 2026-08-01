using Scripts.Config;

namespace SSAR.SkillSystem.View
{
	public class PassiveSkillView : AbsSkillView
	{
		protected override int GetMaxLevel(ISkillStat skillStat)
		{
			return 0;
		}

		protected override string GetNameLocalize(ISkillStat skillStat)
		{
			return null;
		}

		protected override void GetIcon(ISkillStat skillStat, ref UISprite sp_icon)
		{
		}

		protected override void Invest(MainCharacterData mainCharacterData, ISkillStat skillStat, Preset preset)
		{
		}

		protected override void Divest(ISkillStat skillStat, Preset preset)
		{
		}

		protected override int GetCurrentLevel(MainCharacterData mainCharacterData, ISkillStat skillStat, Preset preset)
		{
			return 0;
		}
	}
}
