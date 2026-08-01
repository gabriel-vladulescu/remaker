using System;
using System.Collections.Generic;
using Assets.Scripts.Core.UnlockableSystem;
using Assets.Scripts.Core.UnlockableSystem.Cookies;
using Assets.Scripts.Ssar.DataManager;
using Scripts.Config;
using Ssar.Event.SevenDaysCampaign.Model;

namespace Ssar.Event.SevenDaysCampaign
{
	public class CampaignLogic
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

		private CampaignConfig config;

		private CampaignData campaignData;

		private UnlockableSystem unlockableSystem;

		private Action<int> onUpdateMetric;

		public CampaignLogic(CampaignConfig config, CampaignData campaignData)
		{
		}

		public void ListenOnUpdateMetric(Action<int> callback)
		{
		}

		public void RemoveListenOnUpdateMetric(Action<int> callback)
		{
		}

		public void UpdateMetric(int metricId, int value, string[] cookies)
		{
		}

		public int GetProgressValueByMetricId(int metricId, string[] cookies)
		{
			return 0;
		}

		public List<Property> GetPropertiesByMetricId(int metricId)
		{
			return null;
		}

		private void StoreNewPropertiesIfAny()
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

		private ActivationRule InitRule(CampaignConfig.PropertyItem propertyItem)
		{
			return null;
		}
	}
}
