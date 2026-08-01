using Ssar.Analytics.Metrics;
using strange.extensions.command.impl;

namespace Ssar.Event.Xmas
{
	public class ClaimXmasLoginRewardCmd : Command
	{
		[Inject]
		public int day { get; set; }

		[Inject]
		public Metric metric { get; set; }

		public override void Execute()
		{
		}

		private void AddReward()
		{
		}

		private int GetDayLeft()
		{
			return 0;
		}

		private void SendMetric(int mile, int dayLeft)
		{
		}
	}
}
