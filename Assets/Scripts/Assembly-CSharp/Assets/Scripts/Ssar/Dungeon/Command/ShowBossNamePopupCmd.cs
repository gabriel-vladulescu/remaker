namespace Assets.Scripts.Ssar.Dungeon.Command
{
	public class ShowBossNamePopupCmd : BaseShowPopupCmd
	{
		[Inject]
		public string name { get; set; }

		[Inject]
		public float delay { get; set; }

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
