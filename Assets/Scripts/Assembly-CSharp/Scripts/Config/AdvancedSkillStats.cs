using System.Collections.Generic;

namespace Scripts.Config
{
	public class AdvancedSkillStats
	{
		public AbsHeroConfig.SkillStats baseStats;

		public Dictionary<SkillExtraStatType, double> extraStats;

		public AdvancedSkillStats()
		{
		}

		public AdvancedSkillStats(AbsHeroConfig.SkillStats baseStats)
		{
		}
	}
}
