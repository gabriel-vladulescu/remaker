using System.Collections.Generic;
using Scripts.Config;
using Ssar.Analytics.Metrics;
using Ssar.RaidBoss.Battle;
using Ssar.RaidBoss.Model;

namespace Assets.Scripts.Ssar.Dungeon.Model
{
	public class OnRaidBossWinLogic : IOnBattleWinLogic
	{
		private RaidDropRewardLogic dropRewardLogic;

		private RaidBossConfig.Room roomInfo;

		private RaidTeamData teamData;

		private Metric metric;

		private RaidWinParameter parameter;

		public OnRaidBossWinLogic(RaidBossConfig.Room roomInfo, RaidTeamData teamData, Metric metric)
		{
		}

		public void OnExcute()
		{
		}

		private void Prepare()
		{
		}

		private List<ItemInfo> GenerateRewards()
		{
			return null;
		}

		private List<RaidWinRankInfo> GetRankInfos()
		{
			return null;
		}

		private int GetRank()
		{
			return 0;
		}

		private void AddReward(List<ItemInfo> rewards)
		{
		}

		private void DisplayResult()
		{
		}

		private void ValidateRewardForDisplay()
		{
		}

		private void SaveLocalResult()
		{
		}

		private void UpdateResult()
		{
		}

		private void WinRaidMetric()
		{
		}
	}
}
