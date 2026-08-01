using System.Collections.Generic;

namespace Scripts.Config
{
	public class EventConfig : IConfig
	{
		public Dictionary<string, EventInfo> events;

		public Dictionary<string, DailyQuestConfig.QuestItem> quinnRequestQuests;

		public Dictionary<string, DailyQuestConfig.MetricItem> quinnRequestMetrics;

		public Dictionary<string, QuinnRequestPackInfo> quinnRequestPacks;

		public Dictionary<string, MoreThanCrystalInfo> moreThanCrystalInfos;

		public Dictionary<string, MoreThanCrystalReward> moreThanCrystalRewards;

		public Dictionary<string, MoreThanCrystalInfo> moreThanSoulInfos;

		public Dictionary<string, MoreThanCrystalReward> moreThanSoulRewards;

		private List<DailyQuestConfig.QuestItem> _cacheQuinnRequestQuestInfos;

		private List<DailyQuestConfig.MetricItem> _cacheQuinnRequestMetricItems;

		private List<QuinnRequestPackInfo> _cacheQuinnRequestPackInfos;

		private List<MoreThanCrystalInfo> _cacheMoreThanCrystalInfos;

		private List<MoreThanCrystalReward> _cacheMoreThanCrystalReward;

		private List<MoreThanCrystalInfo> _cacheMoreThanSoulInfos;

		private List<MoreThanCrystalReward> _cacheMoreThanSoulReward;

		public void OnMapValue(string content)
		{
		}

		public EventInfo GetEventInfo(EventCode code)
		{
			return null;
		}

		public bool IsEnableEvent(EventCode eventCode)
		{
			return false;
		}

		public List<DailyQuestConfig.QuestItem> GetQuinnRequestQuestInfos()
		{
			return null;
		}

		public List<DailyQuestConfig.MetricItem> GetQuinnRequestMetricItems()
		{
			return null;
		}

		public List<QuinnRequestPackInfo> GetQuinnRequestPackInfos()
		{
			return null;
		}

		public List<MoreThanCrystalInfo> GetMoreThanCrystalInfo()
		{
			return null;
		}

		public List<MoreThanCrystalReward> GetMoreThanCrystalReward()
		{
			return null;
		}

		public List<MoreThanCrystalInfo> GetMoreThanSoulInfo()
		{
			return null;
		}

		public List<MoreThanCrystalReward> GetMoreThanSoulReward()
		{
			return null;
		}
	}
}
