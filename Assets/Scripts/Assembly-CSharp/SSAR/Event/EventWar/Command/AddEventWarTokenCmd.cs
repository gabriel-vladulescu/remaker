using Ssar.Analytics.Metrics;
using Ssar.Event.EventWar.Model;
using strange.extensions.command.impl;

namespace Ssar.Event.EventWar.Command
{
	public class AddEventWarTokenCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public AddEventWarTokenParams Params { get; set; }

		[Inject]
		public OnAddEventWarTokenSuccessSignal SuccessSignal { get; set; }

		[Inject]
		public Metric metric { get; set; }

		public override void Execute()
		{
		}

		private void SendMetric(int quantity, RewardReason source)
		{
		}
	}
}
