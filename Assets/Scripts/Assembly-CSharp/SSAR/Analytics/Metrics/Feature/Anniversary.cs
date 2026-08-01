using System.Collections.Generic;

namespace Ssar.Analytics.Metrics.Feature
{
	public class Anniversary
	{
		private static Dictionary<int, MetricName> anniversaryLoginDay;

		private static Dictionary<int, MetricName> anniversaryQuest;

		private MetricName metricName;

		private int level;

		private int continuousDayCount;

		static Anniversary()
		{
		}

		public Anniversary(MetricName metricName, int level, int continuousDayCount)
		{
		}

		public void Send()
		{
		}

		public static MetricName GetMetricNameForAnniversaryLoginOfDay(int day)
		{
			return default(MetricName);
		}

		public static MetricName GetMetricNameForAnniversaryQuest(int questCount)
		{
			return default(MetricName);
		}
	}
}
