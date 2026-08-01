namespace Scripts.Ssar.Arena
{
	public class ShowUserMasteryInfoPopupCmd : BaseShowPopupCmd
	{
		[Inject]
		public MainCharacterData MainCharacterData { get; set; }

		[Inject]
		public bool allowEdit { get; set; }

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
