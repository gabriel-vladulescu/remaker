using System;
using Assets.Scripts.Ssar.Common.System;
using Assets.Scripts.Ssar.Common.System.RoutineRunner;
using strange.extensions.command.impl;

namespace Scripts.Config.Remote
{
	public class CheckRemoteConfigVersionCommand : Command
	{
		private class DefaultUpdateGameClientPopup : UpdateGameClientPopup
		{
			public void Show()
			{
			}
		}

		private class DefaultMaintenancePopup : MaintenancePopup
		{
			public void Show(Action<MaintenancePopupAction> resultCallback)
			{
			}
		}

		[Inject]
		public RoutineRunner routineRunner { get; set; }

		[Inject]
		public ConfigManager configManager { get; set; }

		[Inject(/*Could not decode attribute arguments.*/)]
		public DefaultSystem defaultSystem { get; set; }

		public override void Execute()
		{
		}

		public void ReloadConfigManager()
		{
		}
	}
}
