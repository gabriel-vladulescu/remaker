using strange.extensions.command.impl;

namespace Ssar.Analytics.Metrics.Generals.Commands
{
	public class OnGameStartMetricCommand : Command
	{
		[Inject]
		public Metric metric { get; set; }

		public override void Execute()
		{
		}
	}
}
