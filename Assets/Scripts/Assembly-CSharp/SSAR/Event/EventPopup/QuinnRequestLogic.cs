using System.Collections.Generic;
using Assets.Scripts.Core.UnlockableSystem;
using Assets.Scripts.Core.UnlockableSystem.Cookies;
using Assets.Scripts.Ssar.DataManager;
using Scripts.Config;

namespace Ssar.Event.EventPopup
{
	public class QuinnRequestLogic
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

		private UnlockableSystem _unlockableSystem;

		private List<DailyQuestConfig.QuestItem> _questInfos;

		private List<DailyQuestConfig.MetricItem> _metricItems;

		private QuinnRequestEventData _eventData;

		private const int EVENT_ID = 1;

		public QuinnRequestLogic(EventConfig eventConfig, QuinnRequestEventData eventData)
		{
		}

		private bool IsThroughNewDay(int lastTime)
		{
			return false;
		}

		public void UpdateMetric(int metricId, int value, string[] cookies)
		{
		}

		private void GenerateNewQuestData()
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
