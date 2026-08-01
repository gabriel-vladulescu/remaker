namespace Assets.Scripts.Ssar.Command
{
	public class ShowLinkAccountPopupCmd : BaseShowPopupCmd
	{
		[Inject]
		public ShowLinkAccountPopupParameter Parameter { get; set; }

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
