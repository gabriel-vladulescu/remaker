using Assets.Scripts.Ssar.Signal;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Command
{
	public class OnThroughNewDayCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public UserData UserData { get; set; }

		[Inject]
		public UpdateFirstAnniversaryQuestpopupSignal UpdateFirstAnniversaryQuestpopupSignal { get; set; }

		public override void Execute()
		{
		}

		private void NewDay(MainCharacterData mainCharacterData)
		{
		}

		private void UpdateFirstAnniversaryQuestEvent(MainCharacterData mainCharacterData)
		{
		}

		private void UpdateXmasOnlineEvent(MainCharacterData mainCharacterData)
		{
		}

		private void UpdateRaidEntry(MainCharacterData mainCharacterData)
		{
		}

		private void UpdateKey(MainCharacterData mainCharacterData)
		{
		}

		private void UpdateCampaign()
		{
		}

		private void UpdateBoughtPackagesCount(MainCharacterData mainCharacterData)
		{
		}

		private void UpdateDailyChallenge(MainCharacterData mainCharacterData)
		{
		}

		private void UpdateTower(MainCharacterData mainCharacterData)
		{
		}
	}
}
