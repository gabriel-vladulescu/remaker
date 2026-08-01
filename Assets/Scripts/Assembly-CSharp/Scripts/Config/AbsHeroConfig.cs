using System.Collections.Generic;

namespace Scripts.Config
{
	public abstract class AbsHeroConfig : IConfig
	{
		public class SkillStats
		{
			public int groupId;

			public int subId;

			public int skillId;

			public double scalePower;

			public double skillPower;

			public int damageType;

			public bool isActiveSkill;

			public double cooldown;
		}

		public Dictionary<string, HeroBasicStats> basic;

		public Dictionary<string, HeroLevelStats> level;

		public Dictionary<string, SkillStats> skillStats;

		public void OnMapValue(string content)
		{
		}

		protected virtual void Map()
		{
		}

		public HeroBasicStats FindHeroAdvanceStats(int groupId, int id)
		{
			return null;
		}

		public virtual HeroLevelStats FindHeroBasicStats(int groupId, int id, int level)
		{
			return null;
		}

		public SkillStats FindSkillStatsById(string id)
		{
			return null;
		}

		public List<string> ListAllSkillsBy(int groupId, int id, bool isActiveSkill = true)
		{
			return null;
		}

		public List<string> ListAllActiveAndPassiveSkills(int groupId, int subId)
		{
			return null;
		}

		protected void RemappingSkill()
		{
		}
	}
}
