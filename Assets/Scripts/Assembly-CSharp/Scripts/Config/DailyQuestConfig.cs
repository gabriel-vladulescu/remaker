using System;
using System.Collections.Generic;
using CodeStage.AntiCheat.ObscuredTypes;

namespace Scripts.Config
{
	public class DailyQuestConfig : IConfig
	{
		public class QuestItem : WrapContentData
		{
			public int id;

			public string localizationName;

			public string localizationDescription;

			public string[] properties;

			public string rewardType;

			public bool enable;

			public bool notRandom;

			public int order;

			private int[] propertyIds;

			private PropertyItem[] propertyItems;

			private ObscuredInt mRewardValue;

			public int rewardValue
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public string icon => null;

			public int[] PropertyIds => null;

			public PropertyItem[] PropertyItems => null;

			public void ParsePropertiesString()
			{
			}

			private T Try<T>(string property, string value, Func<T> function)
			{
				return default(T);
			}

			public ItemType RewardType()
			{
				return default(ItemType);
			}

			public ItemInfo GetReward()
			{
				return null;
			}
		}

		public class MasterQuestItem
		{
			public int id;

			public int questCount;

			public string rewardType;

			public int rewardValue;

			public string from;

			public string to;

			public string icon => null;

			public int QuestCount => 0;

			public ItemType RewardType()
			{
				return default(ItemType);
			}

			public ItemInfo GetReward()
			{
				return null;
			}

			public bool IsTimeBased()
			{
				return false;
			}

			public bool IsTimeValid()
			{
				return false;
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

		public class MetricItem
		{
			public int id;

			public int propertyGroup;

			private List<int> propertyIds;

			public int[] PropertyIds => null;

			public void AddPropertyId(int id)
			{
			}
		}

		public enum ActRule
		{
			gt = 0
		}

		public Dictionary<string, QuestItem> quests;

		public Dictionary<string, MasterQuestItem> masterQuests;

		public Dictionary<string, PropertyItem> properties;

		public Dictionary<string, MetricItem> metrics;

		private Dictionary<int, List<QuestItem>> metricIdToQuestItems;

		private List<MasterQuestItem> timeBasedMasterQuestItems;

		private List<MasterQuestItem> validTimeBasedMasterQuestItems;

		public void OnMapValue(string content)
		{
		}

		public IEnumerable<QuestItem> ListAllQuests()
		{
			return null;
		}

		public IEnumerable<PropertyItem> ListAllProperties()
		{
			return null;
		}

		public IEnumerable<MetricItem> ListAllMetrics()
		{
			return null;
		}

		public IEnumerable<MasterQuestItem> ListAllMasterQuests()
		{
			return null;
		}

		public IEnumerable<MasterQuestItem> ListAllValidTimeBasedMasterQuests()
		{
			return null;
		}

		public List<QuestItem> GetAllDailyQuest(List<int> questId)
		{
			return null;
		}

		public MasterQuestItem GetMasterQuestItem(int masterQuestId)
		{
			return null;
		}

		private int Comparer(QuestItem a, QuestItem b)
		{
			return 0;
		}

		public PropertyItem GetDailyQuestPropertyItem(int propertyId)
		{
			return null;
		}

		public QuestItem GetDailyQuest(int questId)
		{
			return null;
		}
	}
}
