using Ssar.Analytics.Metrics;
using Ssar.DailyChallenge.Model;
using strange.extensions.command.impl;

namespace Ssar.DailyChallenge.Command
{
	public class UpdateChallengeResultCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public ChallengeEndParameters endParameters { get; set; }

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
