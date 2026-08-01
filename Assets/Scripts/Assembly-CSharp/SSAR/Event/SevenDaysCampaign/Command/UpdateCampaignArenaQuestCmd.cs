using strange.extensions.command.impl;

namespace Ssar.Event.SevenDaysCampaign.Command
{
	public class UpdateCampaignArenaQuestCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public CampaignLogic campaignLogic { get; set; }

		public override void Execute()
		{
		}

		private void UpdateArenaProgress(MainCharacterData mainCharacterData, CampaignLogic campaignLogic)
		{
		}
	}
}
