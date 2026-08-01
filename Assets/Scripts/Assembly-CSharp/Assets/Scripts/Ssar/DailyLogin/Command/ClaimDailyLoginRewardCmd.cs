using Scripts.Config;
using Ssar.Analytics.Metrics;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.DailyLogin.Command
{
	public class ClaimDailyLoginRewardCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public int day { get; set; }

		[Inject]
		public Metric metric { get; set; }

		[Inject]
		public ConfigManager configManager { get; set; }

		public override void Execute()
		{
		}

		private void SendMetric(MainCharacterData mcd, int eventId, string nameReward)
		{
		}

		private void AddReward()
		{
		}

		private DailyLoginGift GetGift(int day)
		{
			return null;
		}
	}
}
