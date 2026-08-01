namespace Assets.Scripts.Ssar.LevelUp.Command
{
	public class ShowCharacterLevelUpPopupCmd : BaseShowPopupCmd
	{
		[Inject]
		public ShowPopupNotifyParameter Parameter { get; set; }

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
