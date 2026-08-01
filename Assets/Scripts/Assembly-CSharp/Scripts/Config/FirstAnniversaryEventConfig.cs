using System.Collections.Generic;
using Assets.Scripts.Ssar.AnniversaryEvent;
using LitJson;
using Ssar.Event;

namespace Scripts.Config
{
	public class FirstAnniversaryEventConfig : IConfig
	{
		public Dictionary<string, FirstAnniversaryQuestConstant> questInfo;

		public Dictionary<string, MilestoneInfo> milestoneInfo;

		public Dictionary<string, QuestDescInfo> questDesc;

		public Dictionary<string, LoginRewardInfo> loginRewards_Lv1;

		public Dictionary<string, EventTimeInfo> time;

		private Dictionary<int, List<LoginRewardInfo>> cache;

		public void OnMapValue(string content)
		{
		}

		private T MapData<T>(JsonData data) where T : class
		{
			return null;
		}

		public List<FirstAnniversaryQuestConstant> GetQuestInfos()
		{
			return null;
		}

		public FirstAnniversaryQuestConstant GetFirstAnniversaryQuestConstant(QuestType questType)
		{
			return null;
		}

		public List<MilestoneInfo> GetMilestoneInfos()
		{
			return null;
		}

		public MilestoneInfo GetMilestoneInfo(int questCount)
		{
			return null;
		}

		public QuestDescInfo GetQuestDescInfo(QuestType questType)
		{
			return null;
		}

		public int GetLoginRewardCount()
		{
			return 0;
		}

		public List<LoginRewardInfo> GetLoginRewards(int characterLv, ref int rewardLv)
		{
			return null;
		}

		public LoginRewardInfo GetLoginReward(int day, int characterLv)
		{
			return null;
		}

		public EventTimeInfo GetTimeInfo(string type)
		{
			return null;
		}

		private int Comparer(MilestoneInfo a, MilestoneInfo b)
		{
			return 0;
		}

		private int Comparer(QuestInfo a, QuestInfo b)
		{
			return 0;
		}
	}
}
