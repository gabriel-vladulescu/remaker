namespace Ssar.Analytics.Metrics.CrossPromotion
{
	public class Interact
	{
		private string promotionName;

		private string rewardType;

		private int rewardValue;

		private string url;

		public Interact(string promotionName, string rewardType, int rewardValue, string url)
		{
		}

		public void Send()
		{
		}

		protected virtual string MetricName()
		{
			return null;
		}
	}
}
