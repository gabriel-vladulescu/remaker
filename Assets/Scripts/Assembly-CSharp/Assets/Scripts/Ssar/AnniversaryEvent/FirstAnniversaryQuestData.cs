using System;
using System.Collections.Generic;
using LitJson;

namespace Assets.Scripts.Ssar.AnniversaryEvent
{
	[Serializable]
	public class FirstAnniversaryQuestData
	{
		[JsonInclude]
		private List<FirstAnniversaryQuestProgress> progresses;

		[JsonInclude]
		private List<QuestInfo> questInfos;

		[JsonInclude]
		private List<ClaimQuestLog> claimQuestLogs;

		public void UpdateListQuest(List<QuestInfo> questInfos)
		{
		}

		public List<QuestInfo> GetQuestInfos()
		{
			return null;
		}

		public QuestInfo GetQuestInfo(int questId)
		{
			return null;
		}

		public FirstAnniversaryQuestProgress GetQuestProgress()
		{
			return null;
		}

		public void ClaimRewardQuest(int questId, int currentTime)
		{
		}

		public void UpdateNewQuest(int questId)
		{
		}

		public ClaimQuestLog GetclaimLog(int questId)
		{
			return null;
		}
	}
}
