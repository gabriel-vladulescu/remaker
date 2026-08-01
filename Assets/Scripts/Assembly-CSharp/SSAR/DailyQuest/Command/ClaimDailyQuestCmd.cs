using Assets.Scripts.Ssar.Signal;
using Scripts.Config;
using Ssar.Analytics.Metrics;
using strange.extensions.command.impl;

namespace Ssar.DailyQuest.Command
{
	public class ClaimDailyQuestCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public DailyQuestConfig.QuestItem questItem { get; set; }

		[Inject]
		public UpdateDailyQuestUISignal UpdateDailyQuestUiSignal { get; set; }

		[Inject]
		public ConfigManager configManager { get; set; }

		[Inject]
		public Metric metric { get; set; }

		public override void Execute()
		{
		}

		private void SendFeatureMetricDailyMissionMinorQuestCompleted()
		{
		}

		private void SendMetric()
		{
		}
	}
}
