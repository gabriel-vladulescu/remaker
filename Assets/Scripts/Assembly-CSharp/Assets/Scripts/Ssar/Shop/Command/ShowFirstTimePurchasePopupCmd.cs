namespace Assets.Scripts.Ssar.Shop.Command
{
	public class ShowFirstTimePurchasePopupCmd : BaseShowPopupCmd
	{
		public override void Execute()
		{
		}

		protected override PopupCamera GetCamera()
		{
			return default(PopupCamera);
		}

		protected override string GetAssetPath()
		{
			return null;
		}

		protected override string GetInjectName()
		{
			return null;
		}
	}
}
