using System;
using System.Collections.Generic;
using CodeStage.AntiCheat.ObscuredTypes;

namespace Scripts.Config
{
	public class JsonAchievementConfig : IConfig
	{
		public class AchievementItem : WrapContentData
		{
			public int id;

			public string name;

			public string explaination;

			public string localizationName;

			public string localizationDescription;

			public string[] properties;

			public string rewardType;

			public string icon;

			public int order;

			private ObscuredInt mRewardValue;

			private int[] propertyIds;

			private PropertyItem[] propertyItems;

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

		public Dictionary<string, AchievementItem> achievements;

		public Dictionary<string, PropertyItem> properties;

		public Dictionary<string, MetricItem> metrics;

		private List<AchievementItem> achievementItems;

		private Dictionary<int, List<AchievementItem>> metricIdToAchievementItems;

		public void OnMapValue(string content)
		{
		}

		public IEnumerable<AchievementItem> ListAllAchievements()
		{
			return null;
		}

		public IEnumerable<PropertyItem> ListAllProperties()
		{
			return null;
		}

		public List<AchievementItem> GetListAchievementWithMetric(int metricId)
		{
			return null;
		}

		public IEnumerable<MetricItem> ListAllMetrics()
		{
			return null;
		}

		public List<AchievementItem> GetListAllAchievementItems()
		{
			return null;
		}

		public AchievementItem GetAchievementItem(int achievementId)
		{
			return null;
		}

		public PropertyItem GetAchievementPropertyItem(int propertyId)
		{
			return null;
		}

		private int Comparer(AchievementItem a, AchievementItem b)
		{
			return 0;
		}
	}
}
