using System;

namespace Assets.Scripts.Ssar.Shop.Command
{
	public class ShowShopPurchaseConfirmPopupCmd : BaseShowPopupCmd
	{
		[Inject]
		public ShowShopPurchaseConfirmPopupParameter Parameter { get; set; }

		[Inject]
		public Action confirm { get; set; }

		public override void Execute()
		{
		}

		protected override string GetAssetPath()
		{
			return null;
		}

		protected override string GetInjectName()
		{
			return null;
		}

		protected override PopupCamera GetCamera()
		{
			return default(PopupCamera);
		}
	}
}
