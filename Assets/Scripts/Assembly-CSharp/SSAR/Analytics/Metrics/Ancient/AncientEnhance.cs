namespace Ssar.Analytics.Metrics.Ancient
{
	public class AncientEnhance : AncientMetric
	{
		private int targetLevel;

		public AncientEnhance(BaseData baseData, AncientEquipmentMetric ancient1, int targetLevel)
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
