using System.Collections.Generic;
using Assets.Scripts.Ssar.Dungeon.Configs;

namespace Assets.Scripts.Config
{
	public class TriggerInspectorToTriggerAdapter : Trigger
	{
		private static Dictionary<string, string> SHORT_NAME_TO_FULL_NAME_MAPPING;

		private TriggerInspector triggerInspector;

		static TriggerInspectorToTriggerAdapter()
		{
		}

		public TriggerInspectorToTriggerAdapter(TriggerInspector triggerInspector)
		{
		}

		public string ClassName()
		{
			return null;
		}

		public IEnumerable<string> CookiesList()
		{
			return null;
		}
	}
}
