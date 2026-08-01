using System.Collections.Generic;

namespace Scripts.Config
{
	public class DailyChallengeMonsterConfig : IConfig
	{
		public class MonsterLevelStats : HeroLevelStats
		{
		}

		private Dictionary<ScenarioDifficulty, Dictionary<string, MonsterLevelStats>> monsterStats;

		private List<string> dicBehaviour;

		private List<string> categories;

		public void OnMapValue(string content)
		{
		}

		private void Setup(string content)
		{
		}

		public List<string> GetListBehaviour()
		{
			return null;
		}

		public List<string> GetCategoriesBahaviour()
		{
			return null;
		}

		public MonsterLevelStats FindMonsterStats(int groupId, int id, int level, ScenarioDifficulty difficulty)
		{
			return null;
		}

		private Dictionary<string, MonsterLevelStats> GetDictMonsterStats(ScenarioDifficulty difficulty)
		{
			return null;
		}
	}
}
