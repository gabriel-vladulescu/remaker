using Scripts.Config;

namespace Assets.Scripts.Ssar.TestDungeon
{
	public class TestDungeonPassiveSkill : TestDungeonSignatureSkillView
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
