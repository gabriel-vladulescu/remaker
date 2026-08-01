using Ssar.RaidBoss.Model;

namespace Ssar.RaidBoss.Command
{
	public class ShowRaidWinPopupCmd : BaseShowPopupCmd
	{
		[Inject]
		public RaidWinParameter Parameter { get; set; }

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
