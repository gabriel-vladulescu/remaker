using Assets.Scripts.Ssar.Signal;
using Scripts.Config;
using Ssar.Analytics.Metrics;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Shop.Command
{
	public class BuyFreeSubscriptionPackageCmd : strange.extensions.command.impl.Command
	{
		private const string DISPLAY_NAME = "Zonmob";

		[Inject]
		public NewSubscribePackageProductInfo productInfo { get; set; }

		[Inject]
		public ConfigManager configManager { get; set; }

		[Inject]
		public Metric metric { get; set; }

		[Inject]
		public BuySubscriptionPackageSuccessSignal buySubscriptionPackageSuccessSignal { get; set; }

		public override void Execute()
		{
		}

		private void SendMetricBuyPackageOrBundle(NewSubscribePackageProductInfo nsppi, double price, string currencyCode)
		{
		}
	}
}
