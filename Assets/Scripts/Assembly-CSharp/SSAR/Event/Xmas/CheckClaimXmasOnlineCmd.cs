using Ssar.Analytics.Metrics;
using strange.extensions.command.impl;

namespace Ssar.Event.Xmas
{
	public class CheckClaimXmasOnlineCmd : Command
	{
		[Inject]
		public Metric metric { get; set; }

		public override void Execute()
		{
		}

		private void AddReward(int order)
		{
		}

		private void SendMetric(int mile)
		{
		}
	}
}
