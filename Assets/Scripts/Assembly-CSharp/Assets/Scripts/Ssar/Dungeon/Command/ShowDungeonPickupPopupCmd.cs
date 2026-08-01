namespace Assets.Scripts.Ssar.Dungeon.Command
{
	public class ShowDungeonPickupPopupCmd : BaseShowPopupCmd
	{
		[Inject]
		public DungeonPickupParameters Parameters { get; set; }

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
