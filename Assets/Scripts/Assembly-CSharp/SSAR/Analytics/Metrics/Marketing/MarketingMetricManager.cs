using System.Collections.Generic;

namespace Ssar.Analytics.Metrics.Marketing
{
	public class MarketingMetricManager
	{
		private class MetricParameters
		{
			private int intValue;

			public int IntValue => 0;

			public MetricParameters(int intValue)
			{
			}

			public MetricParameters(string rawData)
			{
			}
		}

		private Dictionary<MarketingMetricType, MetricParameters> parameters;

		private bool inited;

		private void InitData()
		{
		}

		private void InitDefaultData()
		{
		}

		private void CheckAndInitData()
		{
		}

		public int GetIntParameter(MarketingMetricType type)
		{
			return 0;
		}
	}
}
