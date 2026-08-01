using Ssar.Analytics.Metrics;
using Ssar.Craft.Enum;

namespace Ssar.Craft.Command
{
	public class ShowCraftingPopupCmd : BaseShowPopupCmd
	{
		[Inject]
		public CraftingTabType TabType { get; set; }

		[Inject]
		public Metric Metric { get; set; }

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
