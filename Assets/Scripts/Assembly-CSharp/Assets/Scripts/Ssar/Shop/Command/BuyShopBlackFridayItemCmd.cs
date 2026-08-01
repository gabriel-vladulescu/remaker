using Assets.Scripts.Ssar.Iap;
using Scripts.Config;
using Ssar.Analytics.Metrics;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Shop.Command
{
	public class BuyShopBlackFridayItemCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public ShopBlackFridayItemData itemData { get; set; }

		[Inject]
		public PaymentService paymentService { get; set; }

		[Inject]
		public Metric metric { get; set; }

		[Inject]
		public ConfigManager configManager { get; set; }

		public override void Execute()
		{
		}

		private void SendBuyShopBlackFridayItemMetric()
		{
		}
	}
}
