using Scripts.Config;

namespace Scripts.Ssar.Arena
{
	public class PvpTestPassiveSkill : PvpTestSignatureSkill
	{
		protected override void ChangeLevel(ISkillStat skillStat, int level)
		{
		}

		protected override int GetMaxLevel(ISkillStat skillStat)
		{
			return 0;
		}
	}
}
