using Assets.Scripts.Ssar.Signal;
using Scripts.Config;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Shop.Command
{
	public class BuyBundlePackageSuccessCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public BundlePackageProductInfo ProductInfo { get; set; }

		[Inject]
		public UpdatePetListInventorySignal UpdatePetListInventorySignal { get; set; }

		public override void Execute()
		{
		}
	}
}
