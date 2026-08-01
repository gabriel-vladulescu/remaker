using strange.extensions.command.impl;

namespace Ssar.Event.SevenDaysCampaign.Command
{
	public class InitSevenDaysCampaignLogicCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public UserData userData { get; set; }

		public override void Execute()
		{
		}

		private void UpdateProgress(MainCharacterData mainCharacterData, CampaignLogic campaignLogic)
		{
		}
	}
}
