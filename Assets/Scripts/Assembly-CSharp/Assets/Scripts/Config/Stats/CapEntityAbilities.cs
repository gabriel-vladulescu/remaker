using Scripts.Config;
using Scripts.Config.Stats;

namespace Assets.Scripts.Config.Stats
{
	public class CapEntityAbilities : EntityAbilities
	{
		private readonly int groupId;

		private readonly int subId;

		private HeroConfig heroConfig;

		private StatsCap sc;

		public CapEntityAbilities(int groupId, int subId, HeroConfig heroConfig)
		{
		}

		public override double FinalCritChance()
		{
			return 0.0;
		}

		public override double FinalMagicResist()
		{
			return 0.0;
		}

		public override double FinalAttackSpeed()
		{
			return 0.0;
		}

		public override double FinalCooldownReduction()
		{
			return 0.0;
		}

		public override double FinalBonusMovSpd()
		{
			return 0.0;
		}

		public override double FinalDamageReduction()
		{
			return 0.0;
		}
	}
}
