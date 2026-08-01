using Assets.Scripts.Ssar.Signal;
using Ssar.Analytics.Metrics;
using strange.extensions.command.impl;

namespace Ssar.Ancient.Command
{
	public class EnhanceAncientCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public EnhanceAncientParams Params { get; set; }

		[Inject]
		public OnEnhanceAncientSuccessSignal SuccessSignal { get; set; }

		[Inject]
		public Metric metric { get; set; }

		public override void Execute()
		{
		}

		private void UpdateExp()
		{
		}

		private void DeleteMaterials()
		{
		}

		private void SendMetric(int targetLevel)
		{
		}
	}
}
