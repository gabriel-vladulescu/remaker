using System;
using SSAR.BattleSystem.System.Arena.Api;
using Scripts.Config;
using Ssar.Analytics.Metrics;
using strange.extensions.command.impl;

namespace Scripts.Ssar.Arena
{
	public class ArenaJoinNewSeasonCmd : Command
	{
		[Inject]
		public Action<ArenaJoinNewSeasonCallBack> callBack { get; set; }

		[Inject]
		public Metric metric { get; set; }

		[Inject]
		public ConfigManager configManager { get; set; }

		public override void Execute()
		{
		}

		private void StoreMainCharacterData(MainCharacterData mcd)
		{
		}

		private void JoinCallback(bool success, StatusCode statusCode, string message, JoinSeasonResult joinSeasonResult)
		{
		}

		private void GetNewSeasonInfo(Action finish)
		{
		}

		private void JoinArenaMetric()
		{
		}
	}
}
