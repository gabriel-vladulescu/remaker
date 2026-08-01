using Ssar.Analytics.Metrics;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.AnniversaryEvent
{
	public class ClaimFirstAnniversaryLoginRewardCmd : strange.extensions.command.impl.Command
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

		private void SendMetric(int day, int continousDayCount)
		{
		}
	}
}
