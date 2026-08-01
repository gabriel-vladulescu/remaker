using System.Collections.Generic;
using Assets.Scripts.Ssar.Dungeon.Configs;
using Scripts.Config;

namespace Assets.Scripts.Config
{
	public class TriggerAdapter : Assets.Scripts.Ssar.Dungeon.Configs.Trigger
	{
		private static Dictionary<string, string> SHORT_NAME_TO_FULL_NAME_MAPPING;

		private global::Scripts.Config.Trigger rawTrigger;

		static TriggerAdapter()
		{
		}

		public TriggerAdapter(global::Scripts.Config.Trigger rawTrigger)
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
