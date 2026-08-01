using Assets.Scripts.Ssar.Signal;
using Scripts.Config;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Shop.Command
{
	public class BuyShopBlackFridayItemSuccessCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public ShopBlackFridayItemProductInfo productInfo { get; set; }

		[Inject]
		public OnBuyShopBlackFridayItemSuccessSignal OnBuyShopBlackFridayItemSuccessSignal { get; set; }

		public override void Execute()
		{
		}

		private void Bought()
		{
		}

		private void AddReward()
		{
		}
	}
}
