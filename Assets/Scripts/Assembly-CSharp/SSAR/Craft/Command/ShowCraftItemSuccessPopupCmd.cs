namespace Ssar.Craft.Command
{
	public class ShowCraftItemSuccessPopupCmd : BaseShowPopupCmd
	{
		[Inject]
		public CraftItemSuccessParams Params { get; set; }

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
