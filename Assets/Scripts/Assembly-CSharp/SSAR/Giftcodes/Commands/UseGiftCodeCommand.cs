using Scripts.Config;
using strange.extensions.command.impl;

namespace Ssar.Giftcodes.Commands
{
	public class UseGiftCodeCommand : Command
	{
		[Inject]
		public string code { get; set; }

		[Inject]
		public UseGiftCodeResultSignal UseGiftCodeResultSignal { get; set; }

		[Inject]
		public ConfigManager configManager { get; set; }

		public override void Execute()
		{
		}

		private string DeviceId()
		{
			return null;
		}
	}
}
