using Assets.Scripts.Ssar.Iap;
using SSAR.Entry.Model;
using Scripts.Config;
using Ssar.Analytics.Metrics;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Command
{
	public class BuyCharacterCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public BuyCharacterParameter Parameter { get; set; }

		[Inject]
		public PaymentService paymentService { get; set; }

		[Inject]
		public Metric metric { get; set; }

		public override void Execute()
		{
		}

		private void SendMetricCheckout(CharacterSelectionElementInfo info)
		{
		}
	}
}
