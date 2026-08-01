using Scripts.Ssar.Arena;

namespace Scripts.Config
{
	public class ArenaScalePowerByTierInfo
	{
		public double hpMultiplier;

		public double attackMultiplier;

		public double defMultiplier;

		public double opponentHpMultiplier;

		public double opponentAttackMultiplier;

		public double opponentDefMultiplier;

		public string tier { get; set; }

		public ArenaTier GetArenaTier()
		{
			return default(ArenaTier);
		}
	}
}
