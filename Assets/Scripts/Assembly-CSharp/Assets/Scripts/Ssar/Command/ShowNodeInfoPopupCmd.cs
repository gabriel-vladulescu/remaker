namespace Assets.Scripts.Ssar.Command
{
	public class ShowNodeInfoPopupCmd : BaseShowPopupCmd
	{
		[Inject]
		public int nodeId { get; set; }

		[Inject]
		public bool backToWorldMapWhenClose { get; set; }

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
