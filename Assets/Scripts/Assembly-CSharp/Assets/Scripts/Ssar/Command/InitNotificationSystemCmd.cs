using Assets.Scripts.Ssar.Notifications;
using Scripts.Config;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Command
{
	public class InitNotificationSystemCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public ConfigManager configManager { get; set; }

		public override void Execute()
		{
		}

		private Notification GetNotification()
		{
			return null;
		}
	}
}
