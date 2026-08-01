namespace Assets.Scripts.Ssar.Dungeon.Command
{
	public class ShowDungeonPausePopupCmd : BaseShowPopupCmd
	{
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
