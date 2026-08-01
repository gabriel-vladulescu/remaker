namespace Ssar.Analytics.Metrics.Coreloop
{
	public class ReceivedAchievement
	{
		private readonly CoreloopData coreloopData;

		private readonly int achievementId;

		private readonly string achievementName;

		private readonly int rewardValue;

		private readonly string type;

		public ReceivedAchievement(CoreloopData coreloopData, int achievementId, string achievementName, int rewardValue, string type)
		{
		}

		public void Send()
		{
		}
	}
}
