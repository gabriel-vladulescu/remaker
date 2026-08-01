using Scripts.Config;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Shop.Command
{
	public class BuySpecialItemCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public ShopSpecialProductInfo ProductInfo { get; set; }

		public override void Execute()
		{
		}

		private ItemType GetItemType()
		{
			return default(ItemType);
		}
	}
}
