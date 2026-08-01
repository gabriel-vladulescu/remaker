namespace Ssar.Analytics.Metrics.Feature
{
	public class QuinnRequestEvent : FeatureCustomEventData
	{
		private QuinnRequestEventData _eventData;

		public int ViewCount()
		{
			return 0;
		}

		public int CurrentCoin()
		{
			return 0;
		}

		public int TotalCoin()
		{
			return 0;
		}

		public int TotalExchangeTime()
		{
			return 0;
		}

		public int DailyCount()
		{
			return 0;
		}

		public int TotalDailyQuest()
		{
			return 0;
		}

		public int TotalQuest()
		{
			return 0;
		}

		public int ExchangeTime(int giftId)
		{
			return 0;
		}

		public string TotalGiftId()
		{
			return null;
		}

		public int PreviousEarnCoins()
		{
			return 0;
		}

		public int PreviousSpendCoins()
		{
			return 0;
		}

		public int PreviousExchangeTimes()
		{
			return 0;
		}

		public void SendQuinnRequestAwareness()
		{
		}

		public void SendQuinnRequestComplete(int questId, int coinValue)
		{
		}

		public void SendQuinnRequestExchange(int giftId, int coinValue)
		{
		}

		public void SendQuinnRequestPreviousCoins()
		{
		}
	}
}
