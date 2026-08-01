using System.Collections.Generic;
using Assets.Scripts.Ssar.Dungeon.Configs;
using Scripts.Config;

namespace Assets.Scripts.Config
{
	public class StageActivatorAdapter : Assets.Scripts.Ssar.Dungeon.Configs.StageActivator
	{
		private static Dictionary<string, string> SHORT_NAME_TO_FULL_NAME_MAPPING;

		private global::Scripts.Config.StageActivator rawStageActivator;

		static StageActivatorAdapter()
		{
		}

		public StageActivatorAdapter(global::Scripts.Config.StageActivator rawStageActivator)
		{
		}

		public int Id()
		{
			return 0;
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
