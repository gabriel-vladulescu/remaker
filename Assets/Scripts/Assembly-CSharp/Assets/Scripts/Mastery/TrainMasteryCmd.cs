using System.Collections.Generic;
using Assets.Scripts.Ssar.Signal;
using Scripts.Config;
using Ssar.Achievement;
using Ssar.Analytics.Metrics;
using Ssar.DailyQuest;
using strange.extensions.command.impl;

namespace Assets.Scripts.Mastery
{
	public class TrainMasteryCmd : Command
	{
		[Inject]
		public MasteryInfo MasteryInfo { get; set; }

		[Inject]
		public OnTrainMasterySuccessSignal OnTrainMasterySuccessSignal { get; set; }

		[Inject]
		public Metric metric { get; set; }

		[Inject]
		public ConfigManager configManager { get; set; }

		[Inject]
		public AchievementLogic achievementLogic { get; set; }

		[Inject]
		public DailyQuestLogic dailyQuestLogic { get; set; }

		public override void Execute()
		{
		}

		private void AddExp()
		{
		}

		private void ConsumeMaterial()
		{
		}

		private void OnTrainMasterySuccess(int level, int oldTotalLevel)
		{
		}

		private void UpdateDailyQuest(List<MaterialData> materialDatas)
		{
		}
	}
}
