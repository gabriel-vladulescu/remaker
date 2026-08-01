namespace Assets.Scripts.Ssar.Dungeon.Command
{
	public class ShowArenaOpponentInfoPopupCmd : BaseShowPopupCmd
	{
		[Inject]
		public ShowArenaOpponentInfoPopupParameter Parameter { get; set; }

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
	}
}
