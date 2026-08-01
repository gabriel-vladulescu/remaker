using Ssar.Analytics.Metrics;

namespace Assets.Scripts.Ssar.Shop.Command
{
	public class ShowDoubleExpPackageCategoryPopupCmd : BaseShowPopupCmd
	{
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
