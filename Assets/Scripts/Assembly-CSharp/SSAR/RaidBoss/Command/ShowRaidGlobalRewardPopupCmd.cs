namespace Ssar.RaidBoss.Command
{
	public class ShowRaidGlobalRewardPopupCmd : BaseShowPopupCmd
	{
		[Inject]
		public int seasonCode { get; set; }

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
