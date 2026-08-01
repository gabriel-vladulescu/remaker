using Assets.Scripts.Ssar.Iap;
using Scripts.Config;
using Ssar.Analytics.Metrics;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Shop.Command
{
	public class BuyLevelUpPackageCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public NewLevelUpPackageProductInfo NewLevelUpPackageProductInfo { get; set; }

		[Inject]
		public PaymentService paymentService { get; set; }

		[Inject]
		public ConfigManager configManager { get; set; }

		[Inject]
		public Metric metric { get; set; }

		public override void Execute()
		{
		}

		private void SendMetricCheckout(IProductInfo ProductInfo)
		{
		}
	}
}
