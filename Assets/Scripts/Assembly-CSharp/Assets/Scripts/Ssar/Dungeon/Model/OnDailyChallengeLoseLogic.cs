using Assets.Scripts.Ssar.Dungeon.Command;
using Scripts.Config;
using Ssar.Analytics.Metrics;
using Ssar.DailyChallenge.Model;

namespace Assets.Scripts.Ssar.Dungeon.Model
{
	public class OnDailyChallengeLoseLogic : IOnBattleLoseLogic
	{
		private readonly DailyChallengeConfig.Dungeon dungeonInfo;

		public OnDailyChallengeLoseLogic(DailyChallengeConfig.Dungeon dungeonInfo)
		{
		}

		public void OnExcute(Metric metric, ConfigManager configManager, DungeonLoseReason reason)
		{
		}

		private void LoseWithRewards(ChallengeEndParameters parameters, ChallengeEndParametersWithDemonInvasion ParametersWithDemonInvasion)
		{
		}

		private void AddRewards(ChallengeEndParameters endParameters)
		{
		}
	}
}
