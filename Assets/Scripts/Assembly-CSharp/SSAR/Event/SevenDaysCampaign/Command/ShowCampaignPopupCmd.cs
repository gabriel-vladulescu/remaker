using Ssar.Analytics.Metrics;

namespace Ssar.Event.SevenDaysCampaign.Command
{
	public class ShowCampaignPopupCmd : BaseShowPopupCmd
	{
		[Inject]
		public ShowCampaignParameters Parameters { get; set; }

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
