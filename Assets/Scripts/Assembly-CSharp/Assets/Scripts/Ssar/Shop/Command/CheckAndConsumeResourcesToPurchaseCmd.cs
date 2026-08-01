using System;
using Scripts.Config;
using Ssar.Analytics.Metrics;
using Ssar.DailyQuest;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Shop.Command
{
	public class CheckAndConsumeResourcesToPurchaseCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public Currency currency { get; set; }

		[Inject]
		public int price { get; set; }

		[Inject]
		public Action OnPurchaseAction { get; set; }

		[Inject]
		public Metric metric { get; set; }

		[Inject]
		public ConfigManager configManager { get; set; }

		[Inject]
		public Reason Reason { get; set; }

		[Inject]
		public DailyQuestLogic dql { get; set; }

		public override void Execute()
		{
		}

		private string GetSourceFromReason(Reason reason)
		{
			return null;
		}

		private void UpdateDailyQuest()
		{
		}

		private void SendWatchVodMetric()
		{
		}

		private void SendRewardVodMetric()
		{
		}
	}
}
