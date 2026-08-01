using Assets.Scripts.Ssar.Iap;
using Assets.Scripts.Ssar.Signal;
using Scripts.Config;
using Ssar.Analytics.Metrics;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Shop.Command
{
	public class BuyBundlePackageCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public BuyBundlePackageFailureSignal BuyBundlePackageFailureSignal { get; set; }

		[Inject]
		public BundlePackageProductInfo ProductInfo { get; set; }

		[Inject]
		public PaymentService paymentService { get; set; }

		[Inject]
		public Metric metric { get; set; }

		public override void Execute()
		{
		}

		private void SendMetricCheckout()
		{
		}
	}
}
