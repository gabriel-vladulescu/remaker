namespace Assets.Scripts.Ssar.Command
{
	public class ShowBackgroundPopupCmd : BaseShowPopupCmd
	{
		[Inject]
		public string bgPath { get; set; }

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
