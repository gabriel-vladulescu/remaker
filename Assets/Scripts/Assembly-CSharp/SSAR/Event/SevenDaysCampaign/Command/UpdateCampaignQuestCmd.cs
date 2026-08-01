using Ssar.Event.SevenDaysCampaign.Model;
using strange.extensions.command.impl;

namespace Ssar.Event.SevenDaysCampaign.Command
{
	public class UpdateCampaignQuestCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public UpdateCampaignQuestParameters parameters { get; set; }

		[Inject]
		public CampaignLogic campaignLogic { get; set; }

		public override void Execute()
		{
		}
	}
}
