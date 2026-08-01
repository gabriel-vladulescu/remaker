using Assets.Scripts.Ssar.Iap;
using Scripts.Config;
using Ssar.Analytics.Metrics;
using strange.extensions.command.impl;

namespace Ssar.Event.EventShop.Command
{
	public class BuyEventTokenCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public EventShopTokenProductInfo ProductInfo { get; set; }

		[Inject]
		public PaymentService PaymentService { get; set; }

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
