using System;
using System.Collections.Generic;

namespace Scripts.Config
{
	public class CampaignConfig : IConfig
	{
		public class Constants
		{
			public int durationByDay;
		}

		public class CampaignQuestItem : WrapContentData
		{
			public int id;

			public int day;

			public int order;

			public bool enable;

			public string name;

			public string icon;

			public string localizationName;

			public string localizationDesc;

			public string[] properties;

			public string[] rewardType;

			public int[] rewardValue;

			public int[] rewardQuantity;

			public float[] offset;

			public float scale;

			private int[] propertyIds;

			private PropertyItem[] propertyItems;

			private ItemInfo[] rewardItems;

			public int[] PropertyIds => null;

			public PropertyItem[] PropertyItems => null;

			public ItemInfo[] RewardItems => null;

			public void ParsePropertiesString()
			{
			}

			public void ParseRewards()
			{
			}

			private T Try<T>(string property, string value, Func<T> function)
			{
				return default(T);
			}
		}

		public class MetricItem
		{
			public int id;

			public int propertyGroup;

			public LifetimeMode lifetime;

			private List<int> propertyIds;

			public int[] PropertyIds => null;

			public void AddPropertyId(int id)
			{
			}
		}

		public class PropertyItem
		{
			public int id;

			public string[] cookies;

			public string activationRule;

			public int activationValue;

			public int initValue;

			private int group;

			public int Group => 0;

			public PropertyItem()
			{
			}

			public PropertyItem(int id, int group, string[] cookies, string activationRule, int activationValue, int initValue)
			{
			}

			public ActRule ActivationRule()
			{
				return default(ActRule);
			}
		}

		public enum LifetimeMode
		{
			SingleDay = 0,
			EventTime = 1
		}

		public enum ActRule
		{
			gt = 0
		}

		public Dictionary<string, Constants> constants;

		public Dictionary<string, CampaignQuestItem> masterQuests;

		public Dictionary<string, CampaignQuestItem> quests;

		public Dictionary<string, MetricItem> metrics;

		private Dictionary<string, PropertyItem> properties;

		private Dictionary<int, List<CampaignQuestItem>> dayToQuests;

		private Dictionary<int, List<CampaignQuestItem>> metricIdToQuest;

		private int lastestDay;

		public void OnMapValue(string content)
		{
		}

		private void MapQuestData(CampaignQuestItem questItem)
		{
		}

		public IEnumerable<CampaignQuestItem> GetDayQuests()
		{
			return null;
		}

		public List<CampaignQuestItem> GetQuestsByDay(int day)
		{
			return null;
		}

		public List<CampaignQuestItem> GetMasterQuests()
		{
			return null;
		}

		public List<CampaignQuestItem> GetAllQuests()
		{
			return null;
		}

		public IEnumerable<MetricItem> GetAllMetrics()
		{
			return null;
		}

		public IEnumerable<PropertyItem> GetAllProperties()
		{
			return null;
		}

		public PropertyItem GetPropertyItem(int propertyId)
		{
			return null;
		}

		public List<CampaignQuestItem> GetQuestWithMetric(int metricId)
		{
			return null;
		}

		public int GetLastestDay()
		{
			return 0;
		}

		public Constants GetConstants()
		{
			return null;
		}

		private int Comparer(CampaignQuestItem a, CampaignQuestItem b)
		{
			return 0;
		}
	}
}
