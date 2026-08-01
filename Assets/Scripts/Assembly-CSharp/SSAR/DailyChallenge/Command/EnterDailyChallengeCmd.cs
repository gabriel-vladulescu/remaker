using Ssar.Analytics.Metrics;
using strange.extensions.command.impl;

namespace Ssar.DailyChallenge.Command
{
	public class EnterDailyChallengeCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public EnterDailyChallengeParameters Parameters { get; set; }

		[Inject]
		public Metric metric { get; set; }

		public override void Execute()
		{
		}

		private void SendMetric()
		{
		}
	}
}
