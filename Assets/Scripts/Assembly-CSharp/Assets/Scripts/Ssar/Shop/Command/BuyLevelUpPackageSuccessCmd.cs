using Assets.Scripts.Ssar.Signal;
using Scripts.Config;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Shop.Command
{
	public class BuyLevelUpPackageSuccessCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public NewLevelUpPackageProductInfo ProductInfo { get; set; }

		[Inject]
		public HideNewLevelUpPackageCategoryPopupSignal HideNewLevelUpPackageCategoryPopupSignal { get; set; }

		public override void Execute()
		{
		}
	}
}
