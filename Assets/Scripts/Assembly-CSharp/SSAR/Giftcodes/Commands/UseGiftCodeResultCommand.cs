using Scripts.Config;
using strange.extensions.command.impl;

namespace Ssar.Giftcodes.Commands
{
	public class UseGiftCodeResultCommand : Command
	{
		[Inject]
		public Result result { get; set; }

		[Inject]
		public ConfigManager configManager { get; set; }

		public override void Execute()
		{
		}

		private ItemInfo Parse(GiftCodeOperation.GiftcodeReward reward)
		{
			return null;
		}

		private ItemType GetItemType(string itemType)
		{
			return default(ItemType);
		}
	}
}
