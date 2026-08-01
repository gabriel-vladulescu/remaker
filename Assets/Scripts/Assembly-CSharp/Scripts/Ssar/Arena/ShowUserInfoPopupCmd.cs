using SSAR.BattleSystem.System.Arena.Api;

namespace Scripts.Ssar.Arena
{
	public class ShowUserInfoPopupCmd : BaseShowPopupCmd
	{
		[Inject]
		public MainCharacterData MainCharacterData { get; set; }

		[Inject]
		public UserSeasonProgress UserSeasonProgress { get; set; }

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
