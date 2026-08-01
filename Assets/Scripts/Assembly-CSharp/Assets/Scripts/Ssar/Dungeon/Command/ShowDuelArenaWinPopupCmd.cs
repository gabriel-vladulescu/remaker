namespace Assets.Scripts.Ssar.Dungeon.Command
{
	public class ShowDuelArenaWinPopupCmd : BaseShowPopupCmd
	{
		[Inject]
		public ArenaResultData ArenaWinData { get; set; }

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
