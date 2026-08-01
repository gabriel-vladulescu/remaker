using Scripts.Config;
using Ssar.Analytics.Metrics;
using Ssar.Event.SevenDaysCampaign.Model;
using strange.extensions.command.impl;

namespace Ssar.Event.SevenDaysCampaign.Command
{
	public class ClaimCampaignQuestCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public CampaignConfig.CampaignQuestItem questItem { get; set; }

		[Inject]
		public UpdateCampaignPopupSignal UpdateCampaignPopupSignal { get; set; }

		[Inject]
		public Metric metric { get; set; }

		public override void Execute()
		{
		}

		private void LockAllMasterQuest(CampaignData campaignData)
		{
		}

		private void SendMetric()
		{
		}
	}
}
