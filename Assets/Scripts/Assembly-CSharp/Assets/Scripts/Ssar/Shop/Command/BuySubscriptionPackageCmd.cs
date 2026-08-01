using Assets.Scripts.Ssar.Iap;
using Assets.Scripts.Ssar.Signal;
using Scripts.Config;
using Ssar.Analytics.Metrics;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Shop.Command
{
	public class BuySubscriptionPackageCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public ConfigManager configManager { get; set; }

		[Inject]
		public Metric metric { get; set; }

		[Inject]
		public PaymentService paymentService { get; set; }

		[Inject]
		public NewSubscribePackageProductInfo ProductInfo { get; set; }

		[Inject]
		public HideNewSubscribePackageCategoryPopupSignal HideNewSubscribePackageCategoryPopupSignal { get; set; }

		public override void Execute()
		{
		}

		private void SendMetricCheckout()
		{
		}
	}
}
