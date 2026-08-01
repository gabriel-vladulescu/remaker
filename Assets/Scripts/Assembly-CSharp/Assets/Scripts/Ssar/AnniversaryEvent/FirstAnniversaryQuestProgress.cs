using System;
using LitJson;

namespace Assets.Scripts.Ssar.AnniversaryEvent
{
	[Serializable]
	public class FirstAnniversaryQuestProgress
	{
		[JsonInclude]
		private int id;

		[JsonInclude]
		private int progress;

		[JsonInclude]
		private bool hasClaimed;

		public FirstAnniversaryQuestProgress()
		{
		}

		public FirstAnniversaryQuestProgress(int questId)
		{
		}

		public int GetQuestId()
		{
			return 0;
		}

		public void UpdateProgress(int value)
		{
		}

		public bool HasClaimed()
		{
			return false;
		}

		public void ClaimReward()
		{
		}

		public int GetProgress()
		{
			return 0;
		}
	}
}
