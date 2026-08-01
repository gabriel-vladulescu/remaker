using Assets.Scripts.Config;

namespace Ssar.DailyChallenge.Model
{
	public class DailyChallengeDungeonConfigAdapter : MixDungeonConfigAdapter
	{
		public DailyChallengeDungeonConfigAdapter(RawDungeonConfig rawDungeonConfig, DailyChallengeConfigInspector configInspector)
			: base(null, null)
		{
		}

		protected override int[] GetStageIds(RawDungeon rawDungeon)
		{
			return null;
		}
	}
}
