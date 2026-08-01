using strange.extensions.command.impl;

namespace Ssar.DailyReward.Command
{
	public class ClaimDailyRewardCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public int watchAdsIndex { get; set; }

		[Inject]
		public DailyRewardInfo[] dailyRewardInfo { get; set; }

		public override void Execute()
		{
		}

		private void OnReward()
		{
		}

		private void AddReward()
		{
		}
	}
}
