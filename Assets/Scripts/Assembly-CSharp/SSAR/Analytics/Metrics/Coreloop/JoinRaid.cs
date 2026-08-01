namespace Ssar.Analytics.Metrics.Coreloop
{
	public class JoinRaid
	{
		private CoreloopData coreloopData;

		private int seasonalCode;

		public JoinRaid(CoreloopData coreloopData, int seasonalCode)
		{
		}

		public void Send()
		{
		}

		protected virtual MetricName GetMetricName()
		{
			return default(MetricName);
		}

		protected virtual NewMetricName GetNewMetricName()
		{
			return default(NewMetricName);
		}
	}
}
