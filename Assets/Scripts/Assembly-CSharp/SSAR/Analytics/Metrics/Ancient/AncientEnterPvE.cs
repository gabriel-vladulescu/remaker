namespace Ssar.Analytics.Metrics.Ancient
{
	public class AncientEnterPvE : AncientMetric
	{
		private AncientEquipmentMetric ancient2;

		public AncientEnterPvE(BaseData baseData, AncientEquipmentMetric ancient1, AncientEquipmentMetric ancient2)
			: base(null, null)
		{
		}

		protected override MetricName GetMetricName()
		{
			return default(MetricName);
		}

		protected override NewMetricName GetNewMetricName()
		{
			return default(NewMetricName);
		}

		protected override void AddParams(CustomEventData ced)
		{
		}

		protected override void AddParams(NewCustomEventData nced)
		{
		}
	}
}
