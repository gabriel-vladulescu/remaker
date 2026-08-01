namespace Ssar.Analytics.Metrics.Ancient
{
	public abstract class AncientMetric
	{
		private BaseData baseData;

		private AncientEquipmentMetric ancient1;

		protected AncientMetric(BaseData baseData, AncientEquipmentMetric ancient1)
		{
		}

		public void Send()
		{
		}

		protected abstract MetricName GetMetricName();

		protected abstract NewMetricName GetNewMetricName();

		protected abstract void AddParams(CustomEventData ced);

		protected abstract void AddParams(NewCustomEventData nced);
	}
}
