using System;
using System.Collections.Generic;

namespace Assets.Scripts.Ssar.DataManager
{
	[Serializable]
	public class DailyQuestData
	{
		public int lastRefreshTimeInSeconds;

		public List<int> questIds;

		public int masterQuestId;

		public List<Progress> progresses;

		public Dictionary<string, DailyQuestStatus> questStatuses;

		public DailyQuestStatus masterQuestStatus;

		public bool isNewDailyQuest;

		public bool AnyUnlockedQuestNotClaimed()
		{
			return false;
		}

		public void AddProgress(Progress p)
		{
		}

		public bool FindProgress(int id, ref Progress progress)
		{
			return false;
		}

		public List<int> GetListQuestId()
		{
			return null;
		}

		public int GetListQuestUnlocked()
		{
			return 0;
		}

		public int GetMasterQuestId()
		{
			return 0;
		}

		public bool IsClaimed(int questId)
		{
			return false;
		}

		public bool IsCanClaim(int questId)
		{
			return false;
		}

		public bool IsClaimedMasterQuest()
		{
			return false;
		}

		public bool IsUnlockMasterQuest()
		{
			return false;
		}

		public void ClaimMasterQuest()
		{
		}

		public void ClaimDailyQuest(int questId)
		{
		}

		public bool HasClaimAnyQuest()
		{
			return false;
		}

		public bool IsNewDailyQuest()
		{
			return false;
		}

		public void SetIsNewDailyQuest(bool isNew)
		{
		}
	}
}
