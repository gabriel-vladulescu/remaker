using System.Collections.Generic;
using Assets.Scripts.Ssar.AnniversaryEvent;
using Assets.Scripts.Ssar.Dungeon.GameModeLogic;
using LitJson;
using Ssar.Event;
using Ssar.Event.Xmas;

namespace Scripts.Config
{
	public class XmasEventConfig : IConfig
	{
		public Dictionary<string, EventTimeInfo> time;

		public Dictionary<string, XmasWarQuest> warQuests;

		public Dictionary<string, XmasWarDesc> warDesc;

		public Dictionary<string, XmasWarMilestone> warMilestones;

		public Dictionary<string, LoginRewardInfo> loginRewards_Lv1;

		public Dictionary<string, OnlineRewardInfo> onlineRewards_Lv1;

		private Dictionary<int, List<LoginRewardInfo>> dictLoginRewards;

		private Dictionary<int, List<OnlineRewardInfo>> dictOnlineRewards;

		public void OnMapValue(string content)
		{
		}

		private T MapData<T>(JsonData data) where T : class
		{
			return null;
		}

		public EventTimeInfo GetTimeInfo(string type)
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

		public int GetMaxOnlineRewardCount()
		{
			return 0;
		}

		public List<OnlineRewardInfo> GetOnlineRewards(int characterLv, ref int rewardLv)
		{
			return null;
		}

		public OnlineRewardInfo GetOnlineReward(int order, int characterLv)
		{
			return null;
		}

		public XmasWarQuest GetWarQuestById(int id)
		{
			return null;
		}

		public XmasWarQuest GetWarQuest(XmasWarQuestType type, BattleMode mode, ScenarioDifficulty difficulty)
		{
			return null;
		}

		public int GetWarMilestoneCount()
		{
			return 0;
		}

		public XmasWarMilestone GetWarMilestone(int id)
		{
			return null;
		}

		public XmasWarMilestone[] GetListWarMilestones()
		{
			return null;
		}

		public int GetWarDescCount()
		{
			return 0;
		}

		public XmasWarDesc[] GetListWarDescs()
		{
			return null;
		}
	}
}
