using System;
using System.Collections.Generic;
using Assets.Scripts.Core.UnlockableSystem;
using Assets.Scripts.Core.UnlockableSystem.Cookies;
using Assets.Scripts.Ssar.DataManager;
using Scripts.Config;

namespace Ssar.Achievement
{
	public class AchievementLogic
	{
		private class DefaultLog : Logger
		{
			public void info(params object[] objects)
			{
			}
		}

		private class DefaultValue : SyncedValueProperty.Value
		{
			private Progress progress;

			public DefaultValue(Progress progress)
			{
			}

			public int get()
			{
				return 0;
			}

			public void set(int value)
			{
			}
		}

		private JsonAchievementConfig achievementConfig;

		private AchievementData achievementData;

		private UnlockableSystem unlockableSystem;

		private Action<int> actionUpdateMetric;

		private Action<List<Entity>> actionUnlockedEntities;

		public AchievementLogic(JsonAchievementConfig achievementConfig, AchievementData achievementData)
		{
		}

		private static void StoreNewPropertiesIfAny(JsonAchievementConfig achievementConfig, AchievementData achievementData)
		{
		}

		public void ListenOnUpdateMetric(Action<int> action)
		{
		}

		public void RemoveListenOnUpdateMetric(Action<int> action)
		{
		}

		public void ListenToUnlockedEntities(Action<List<Entity>> listener)
		{
		}

		public void UnlistenToUnlockedEntities(Action<List<Entity>> listener)
		{
		}

		public Entity[] UpdateMetric(int metricId, int value, string[] cookies)
		{
			return null;
		}

		public int GetValueByMetricId(int metricId, string[] cookies)
		{
			return 0;
		}

		private void setupUnlockableSystem()
		{
		}

		private void defineEntities()
		{
		}

		private void defineMetrics()
		{
		}

		private void defineProperties()
		{
		}

		private ActivationRule initRule(JsonAchievementConfig.PropertyItem propertyItem)
		{
			return null;
		}
	}
}
