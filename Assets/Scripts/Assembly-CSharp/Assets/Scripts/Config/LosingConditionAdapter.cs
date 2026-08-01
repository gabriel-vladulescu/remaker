using System.Collections.Generic;
using Assets.Scripts.Ssar.Dungeon.Configs;

namespace Assets.Scripts.Config
{
	public class LosingConditionAdapter : LosingCondition
	{
		private static Dictionary<string, string> SHORT_NAME_TO_FULL_NAME_MAPPING;

		private RawLosingCondition rawLosingCondition;

		static LosingConditionAdapter()
		{
		}

		public LosingConditionAdapter(RawLosingCondition rawLosingCondition)
		{
		}

		public string Name()
		{
			return null;
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
