namespace Ssar.Analytics.Metrics.Ancient
{
	public class AncientEnterRaid : AncientEnterPvE
	{
		public AncientEnterRaid(BaseData baseData, AncientEquipmentMetric ancient1, AncientEquipmentMetric ancient2)
			: base(null, null, null)
		{
		}

		protected override MetricName GetMetricName()
		{
			return default(MetricName);
		}
	}
}
