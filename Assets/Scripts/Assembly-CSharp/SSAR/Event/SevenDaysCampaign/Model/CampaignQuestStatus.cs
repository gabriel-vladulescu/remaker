using System;

namespace Ssar.Event.SevenDaysCampaign.Model
{
	[Serializable]
	public class CampaignQuestStatus
	{
		public int questId;

		public bool isClaimed;

		public bool isUnlock;
	}
}
