namespace Scripts.Ssar.Arena
{
	public class ShowCurrentSeasonPopupCmd : BaseShowPopupCmd
	{
		[Inject]
		public RankData ShowCurrentSeasonPopupParameter { get; set; }

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
