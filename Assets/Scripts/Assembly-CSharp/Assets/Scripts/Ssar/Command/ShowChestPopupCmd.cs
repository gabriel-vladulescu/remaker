using Ssar.Analytics.Metrics;

namespace Assets.Scripts.Ssar.Command
{
	public class ShowChestPopupCmd : BaseShowPopupCmd
	{
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
