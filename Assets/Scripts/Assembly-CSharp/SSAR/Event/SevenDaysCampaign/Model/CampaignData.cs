using System;
using System.Collections.Generic;
using Assets.Scripts.Ssar.DataManager;
using CodeStage.AntiCheat.ObscuredTypes;
using LitJson;

namespace Ssar.Event.SevenDaysCampaign.Model
{
	[Serializable]
	public class CampaignData
	{
		[JsonInclude]
		private ObscuredInt timeGenerated;

		[JsonInclude]
		private ObscuredInt lastLoginTime;

		[JsonInclude]
		private List<Progress> progresses;

		[JsonInclude]
		private Dictionary<string, CampaignQuestStatus> questStatuses;

		public void AddProgress(Progress newProgress)
		{
		}

		public bool FindProgress(int id, ref Progress progress)
		{
			return false;
		}

		public List<int> GetPropertyIds()
		{
			return null;
		}

		public int GetTimeGenerated()
		{
			return 0;
		}

		public void SetTimeGenerated(int time)
		{
		}

		public int GetLastLoginTime()
		{
			return 0;
		}

		public void SaveLastLoginTime()
		{
		}

		public CampaignQuestStatus GetQuestStatus(int questId)
		{
			return null;
		}

		public bool IsClaimed(int questId)
		{
			return false;
		}

		public void ClaimQuest(int questId)
		{
		}
	}
}
