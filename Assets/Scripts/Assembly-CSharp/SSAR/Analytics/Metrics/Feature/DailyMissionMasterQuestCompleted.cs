namespace Ssar.Analytics.Metrics.Feature
{
	public class DailyMissionMasterQuestCompleted
	{
		private FeatureData featureData;

		public DailyMissionMasterQuestCompleted(FeatureData featureData)
		{
		}

		public void Send()
		{
		}

		protected virtual MetricName GetMetricName()
		{
			return default(MetricName);
		}
	}
}
