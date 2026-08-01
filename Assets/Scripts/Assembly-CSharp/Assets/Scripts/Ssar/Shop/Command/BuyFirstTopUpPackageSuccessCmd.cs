using Assets.Scripts.Ssar.Signal;
using Scripts.Config;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Shop.Command
{
	public class BuyFirstTopUpPackageSuccessCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public FirstTimePurchaseProductInfo ProductInfo { get; set; }

		[Inject]
		public OnBuyFirstTopUpPackageSuccessSignal OnBuyFirstTopUpPackageSuccessSignal { get; set; }

		public override void Execute()
		{
		}
	}
}
