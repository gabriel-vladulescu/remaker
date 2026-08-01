using Ssar.Analytics.Metrics;
using strange.extensions.command.impl;

namespace Ssar.Event.Xmas
{
	public class ClaimXmasWarMilestoneCmd : Command
	{
		[Inject]
		public int milestoneId { get; set; }

		[Inject]
		public Metric metric { get; set; }

		public override void Execute()
		{
		}

		private bool CheckValidPoint(XmasWarMilestone milestone)
		{
			return false;
		}

		private void AddReward(XmasWarMilestone milestone)
		{
		}

		private void SendMetric(int mile)
		{
		}
	}
}
