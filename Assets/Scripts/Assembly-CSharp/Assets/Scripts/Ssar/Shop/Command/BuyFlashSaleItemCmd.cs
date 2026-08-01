using Assets.Scripts.Ssar.Iap;
using Scripts.Config;
using Ssar.Analytics.Metrics;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Shop.Command
{
	public class BuyFlashSaleItemCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public PaymentService paymentService { get; set; }

		[Inject]
		public FlashSaleItemInfo ItemInfo { get; set; }

		[Inject]
		public Metric metric { get; set; }

		public override void Execute()
		{
		}

		private bool HasBought()
		{
			return false;
		}

		private void SendMetricCheckout(FlashSaleItemInfo ProductInfo)
		{
		}
	}
}
