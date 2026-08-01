using Assets.Scripts.Ssar.Signal;
using Scripts.Config;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Shop.Command
{
	public class BuySubscriptionPackageSuccessCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public NewSubscribePackageProductInfo NewSubscribePackageProductInfo { get; set; }

		[Inject]
		public HideNewSubscribePackageCategoryPopupSignal HideNewSubscribePackageCategoryPopupSignal { get; set; }

		public override void Execute()
		{
		}
	}
}
