namespace Ssar.Analytics.Metrics.CrossPromotion
{
	public class Receive : Interact
	{
		public Receive(string promotionName, string rewardType, int rewardValue, string url)
			: base(null, null, 0, null)
		{
		}

		protected override string MetricName()
		{
			return null;
		}
	}
}
