namespace Ssar.Analytics.Metrics.Ancient
{
	public class AncientEnterPvP : AncientEnterPvE
	{
		public AncientEnterPvP(BaseData baseData, AncientEquipmentMetric ancient1, AncientEquipmentMetric ancient2)
			: base(null, null, null)
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
	}
}
