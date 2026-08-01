using System.Collections.Generic;
using Assets.Scripts.Ssar.Dungeon.Configs;
using Scripts.Config;

namespace Assets.Scripts.Config
{
	public class GateAdapter : Assets.Scripts.Ssar.Dungeon.Configs.Gate
	{
		private static Dictionary<string, string> SHORT_NAME_TO_FULL_NAME_MAPPING;

		private global::Scripts.Config.Gate rawGate;

		static GateAdapter()
		{
		}

		public GateAdapter(global::Scripts.Config.Gate rawGate)
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
