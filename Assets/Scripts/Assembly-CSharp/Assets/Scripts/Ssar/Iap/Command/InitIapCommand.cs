using Assets.Scripts.Ssar.Common.System.RoutineRunner;
using Scripts.Config;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Iap.Command
{
	public class InitIapCommand : strange.extensions.command.impl.Command
	{
		[Inject]
		public RoutineRunner routineRunner { get; set; }

		[Inject]
		public ConfigManager configManager { get; set; }

		[Inject]
		public OnPurchaseResultSignal onPurchaseResultSignal { get; set; }

		public override void Execute()
		{
		}
	}
}
