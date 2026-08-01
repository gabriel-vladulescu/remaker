namespace Ssar.RaidBoss.Command
{
	public class ShowRaidStartNewSeasonPopupCmd : BaseShowPopupCmd
	{
		[Inject]
		public ShowRaidStartNewSeasonParameter Parameter { get; set; }

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
