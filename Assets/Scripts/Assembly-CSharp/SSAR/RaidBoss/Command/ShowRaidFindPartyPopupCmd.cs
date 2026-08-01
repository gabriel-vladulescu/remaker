namespace Ssar.RaidBoss.Command
{
	public class ShowRaidFindPartyPopupCmd : BaseShowPopupCmd
	{
		[Inject]
		public ShowRaidFindPartyPopupParameter Parameter { get; set; }

		public override void Execute()
		{
		}

		protected override PopupCamera GetCamera()
		{
			return default(PopupCamera);
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
