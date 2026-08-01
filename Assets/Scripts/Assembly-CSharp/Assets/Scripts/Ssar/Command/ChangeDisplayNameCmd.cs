using Assets.Scripts.Ssar.Signal;
using Ssar.Analytics.Metrics;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Command
{
	public class ChangeDisplayNameCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public string displayName { get; set; }

		[Inject]
		public OnChangeDisplayNameSuccessSignal OnChangeDisplayNameSuccessSignal { get; set; }

		[Inject]
		public Metric metric { get; set; }

		public override void Execute()
		{
		}

		private void SendMetric(MainCharacterData mainCharacterData)
		{
		}
	}
}
