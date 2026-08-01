using Assets.Scripts.Ssar.Signal;
using Scripts.Config;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Shop.Command
{
	public class BuyDoubleExpPackageSuccessCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public DoubleExpPackageProductInfo ProductInfo { get; set; }

		[Inject]
		public OnBuyDoubleExppackageSuccessSignal OnBuyDoubleExppackageSuccessSignal { get; set; }

		public override void Execute()
		{
		}
	}
}
