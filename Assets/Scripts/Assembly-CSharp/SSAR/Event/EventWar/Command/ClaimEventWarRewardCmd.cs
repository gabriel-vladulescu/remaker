using Scripts.Config;
using Ssar.Analytics.Metrics;
using Ssar.Event.EventWar.Model;
using strange.extensions.command.impl;

namespace Ssar.Event.EventWar.Command
{
	public class ClaimEventWarRewardCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public int rewardId { get; set; }

		[Inject]
		public OnClaimEventWarRewardSuccessSignal OnClaimEventWarRewardSuccessSignal { get; set; }

		[Inject]
		public Metric metric { get; set; }

		public override void Execute()
		{
		}

		private bool IsValidToken(EventWarReward reward)
		{
			return false;
		}

		private void AddReward(EventWarReward reward)
		{
		}

		private void SendMetric(int rewardId)
		{
		}
	}
}
