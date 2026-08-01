using System.Collections.Generic;
using Assets.Scripts.Ssar.Dungeon.Configs;

namespace Assets.Scripts.Config
{
	public class GoalAdapter : Goal
	{
		private static Dictionary<string, string> SHORT_NAME_TO_FULL_NAME_MAPPING;

		private RawGoal rawGoal;

		static GoalAdapter()
		{
		}

		public GoalAdapter(RawGoal rawGoal)
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
