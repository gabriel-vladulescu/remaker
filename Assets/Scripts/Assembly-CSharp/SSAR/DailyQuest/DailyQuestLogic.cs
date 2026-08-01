using System;
using System.Runtime.CompilerServices;
using Assets.Scripts.Core.UnlockableSystem;
using Assets.Scripts.Core.UnlockableSystem.Cookies;
using Assets.Scripts.Ssar.DataManager;
using Scripts.Config;

namespace Ssar.DailyQuest
{
	public class DailyQuestLogic
	{
		public delegate void OnQuestUnlocked(int questId);

		public delegate void OnMasterQuestUnlocked();

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

		private DailyQuestData dailyQuestData;

		private DailyQuestConfig dailyQuestConfig;

		private UnlockableSystem unlockableSystem;

		public Action<int, int, string[]> OnUpdateMetric;

		private event OnQuestUnlocked onQuestUnlockedEvent;

		private event OnMasterQuestUnlocked onMasterQuestUnlockedEvent;

		public DailyQuestLogic(DailyQuestData dailyQuestData, DailyQuestConfig dailyQuestConfig)
		{
		}

		public void ManualResetQuest()
		{
		}

		public void ListenToQuestUnlockedEvent(OnQuestUnlocked listener)
		{
		}

		public void UnlistenToQuestUnlockedEvent(OnQuestUnlocked listener)
		{
		}

		public void ListenToMasterQuestUnlockedEvent(OnMasterQuestUnlocked listener)
		{
		}

		public void UnlistenToMasterQuestUnlockedEvent(OnMasterQuestUnlocked listener)
		{
		}

		public Entity[] UpdateMetric(int metricId, int value, string[] cookies)
		{
			return null;
		}

		public bool ClaimQuest(int questId)
		{
			return false;
		}

		public bool ClaimMasterQuest()
		{
			return false;
		}

		private void GenerateNewQuestsIfTodayIsNewDay()
		{
		}

		private void GenerateNewQuestData(int currentTime)
		{
		}

		private void SetupUnlockableSystem()
		{
		}

		private void DefineEntities()
		{
		}

		private void DefineMetrics()
		{
		}

		private void DefineProperties()
		{
		}

		private ActivationRule InitRule(DailyQuestConfig.PropertyItem propertyItem)
		{
			return null;
		}
	}
}
