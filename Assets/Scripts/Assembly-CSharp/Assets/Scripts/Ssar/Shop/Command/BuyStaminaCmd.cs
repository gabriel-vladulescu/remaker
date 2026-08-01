using Scripts.Config;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Shop.Command
{
	public class BuyStaminaCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public ShopStaminaProductInfo ProductInfo { get; set; }

		public override void Execute()
		{
		}

		private ItemInfo GetItemInfo()
		{
			return null;
		}
	}
}
