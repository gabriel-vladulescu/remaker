using System.Collections.Generic;

namespace Scripts.Config
{
	public class MonsterConfig : AbsHeroConfig
	{
		public Dictionary<string, HeroLevelStats> level_1_3_NORMAL;

		public Dictionary<string, HeroLevelStats> level_1_3_HARD;

		public Dictionary<string, HeroLevelStats> level_1_3_HELL;

		public Dictionary<string, HeroLevelStats> level_1_3_INSANE;

		public Dictionary<string, SkillStats> skillStats_1_3_NORMAL;

		private Dictionary<string, HeroLevelStats> dict;

		private List<string> dicBehaviour;

		private List<string> categories;

		protected override void Map()
		{
		}

		public HeroLevelStats FindHeroBasicStats(int groupId, int id, int level, ScenarioDifficulty difficulty)
		{
			return null;
		}

		private string GetCategoryFromAITag(string aitag)
		{
			return null;
		}

		public List<string> GetListBehaviour()
		{
			return null;
		}

		public List<string> GetCategoriesBahaviour()
		{
			return null;
		}

		public bool IsMonsterSkill(string fullSkillId)
		{
			return false;
		}

		private void AddToDict(Dictionary<string, HeroLevelStats> d, ref Dictionary<string, HeroLevelStats> ret)
		{
		}

		private void AddToDict(Dictionary<string, SkillStats> d, ref Dictionary<string, SkillStats> ret)
		{
		}
	}
}
