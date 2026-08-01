using Ssar.Analytics.Metrics;
using strange.extensions.command.impl;

namespace Ssar.Event.DemonInvasion.Command
{
	public class AddEventDemonTokenCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public AddDemonTokenParams Params { get; set; }

		[Inject]
		public Metric metric { get; set; }

		public override void Execute()
		{
		}

		private void AddEventDemonTokenSuccessSignal()
		{
		}

		private void SendMetric(int quantity, RewardReason source)
		{
		}
	}
}
