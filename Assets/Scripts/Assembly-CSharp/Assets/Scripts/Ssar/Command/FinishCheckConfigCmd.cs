using Assets.Scripts.Ssar.Signal;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Command
{
	public class FinishCheckConfigCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public OnFinishCheckConfigSignal OnFinishCheckConfigSignal { get; set; }

		[Inject]
		public AdjustAdsControllerConfigSignal adjustAdsControllerConfigSignal { get; set; }

		public override void Execute()
		{
		}
	}
}
