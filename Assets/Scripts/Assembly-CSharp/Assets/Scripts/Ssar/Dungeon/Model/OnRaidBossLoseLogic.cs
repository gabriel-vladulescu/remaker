using Assets.Scripts.Ssar.Dungeon.Command;
using Scripts.Config;
using Ssar.Analytics.Metrics;
using Ssar.RaidBoss.Model;

namespace Assets.Scripts.Ssar.Dungeon.Model
{
	public class OnRaidBossLoseLogic : IOnBattleLoseLogic
	{
		private RaidBossConfig.Room roomInfo;

		private RaidTeamData teamData;

		private Metric metric;

		public OnRaidBossLoseLogic(RaidBossConfig.Room roomInfo, RaidTeamData teamData, Metric metric)
		{
		}

		public void OnExcute(Metric metric, ConfigManager configManager, DungeonLoseReason reason)
		{
		}

		private void SaveLocalResult()
		{
		}

		private void UpdateResult(DungeonLoseReason reason)
		{
		}

		private void LoseRaidMetric(DungeonLoseReason reason)
		{
		}
	}
}
