namespace Assets.Scripts.Ssar.Command
{
	public class ShowConfirmPopupCmd : BaseShowPopupCmd
	{
		[Inject]
		public ShowConfirmPopupParameter Parameter { get; set; }

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
