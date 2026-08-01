using System.Collections.Generic;
using Assets.Scripts.Ssar.Dungeon.Configs;

namespace Assets.Scripts.Config
{
	public class StageActivatorInspectorToStageActivatorAdapter : StageActivator
	{
		private static Dictionary<string, string> SHORT_NAME_TO_FULL_NAME_MAPPING;

		private StageActivatorInspector stageActivatorInspector;

		static StageActivatorInspectorToStageActivatorAdapter()
		{
		}

		public StageActivatorInspectorToStageActivatorAdapter(StageActivatorInspector stageActivatorInspector)
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
