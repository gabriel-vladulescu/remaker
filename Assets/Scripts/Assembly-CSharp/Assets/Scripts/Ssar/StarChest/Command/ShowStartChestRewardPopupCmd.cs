using Scripts.Config;

namespace Assets.Scripts.Ssar.StarChest.Command
{
	public class ShowStartChestRewardPopupCmd : BaseShowPopupCmd
	{
		[Inject]
		public MapInfo MapInfo { get; set; }

		[Inject]
		public ScenarioDifficulty ScenarioDifficulty { get; set; }

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
