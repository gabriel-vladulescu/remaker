namespace Ssar.Analytics.Metrics.Feature
{
	public class DailyMissionMinorQuestCompleted : DailyMissionMasterQuestCompleted
	{
		public DailyMissionMinorQuestCompleted(FeatureData featureData)
			: base(null)
		{
		}

		protected override MetricName GetMetricName()
		{
			return default(MetricName);
		}
	}
}
