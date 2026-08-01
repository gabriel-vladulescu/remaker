using System.Collections.Generic;

namespace Ssar.Analytics.Metrics.Marketing
{
	public class MarketingPassMap : BaseMarketingMetric
	{
		private string prefix;

		private Dictionary<int, string> valueRefs;

		private int dungeonID;

		private string node;

		public MarketingPassMap(BaseData baseData, int dungeonID)
			: base(null)
		{
		}

		private string GetEventName()
		{
			return null;
		}

		protected override string GetMetricName()
		{
			return null;
		}

		public void CheckAndSend()
		{
		}

		protected override void AddParams(CustomEventData ced)
		{
		}
	}
}
