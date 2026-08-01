using SSAR.Dungeon.Model;
using Ssar.Analytics.Metrics;

namespace Assets.Scripts.Ssar.Dungeon.Command
{
	public class ShowDungeonWinPopupCmd : BaseShowPopupCmd
	{
		[Inject]
		public DungeonWinParameter Parameter { get; set; }

		[Inject]
		public Metric metric { get; set; }

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
