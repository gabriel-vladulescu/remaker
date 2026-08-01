using Ssar.Analytics.Metrics;
using strange.extensions.command.impl;

namespace Ssar.Event.DemonInvasion.Command
{
	public class OnClaimRewardCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public Metric metric { get; set; }

		[Inject]
		public bool isDemon { get; set; }

		[Inject]
		public int id { get; set; }

		public override void Execute()
		{
		}

		private void OnClaimRewardSuccessSignal()
		{
		}
	}
}
