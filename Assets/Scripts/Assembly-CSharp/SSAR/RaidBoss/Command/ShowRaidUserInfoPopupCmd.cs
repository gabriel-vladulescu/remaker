using Ssar.RaidBoss.Model;

namespace Ssar.RaidBoss.Command
{
	public class ShowRaidUserInfoPopupCmd : BaseShowPopupCmd
	{
		[Inject]
		public MainCharacterData MainCharacterData { get; set; }

		[Inject]
		public RaidProgress Progress { get; set; }

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
