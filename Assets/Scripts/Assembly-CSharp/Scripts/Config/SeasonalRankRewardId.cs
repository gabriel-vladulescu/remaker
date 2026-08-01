using Scripts.Ssar.Arena;

namespace Scripts.Config
{
	public class SeasonalRankRewardId
	{
		public int cosmeticCard { get; set; }

		public int equipmentCard { get; set; }

		public int runeCard { get; set; }

		public int petCard { get; set; }

		public int craftingMaterial { get; set; }

		public string tier { get; set; }

		public int rank { get; set; }

		public ArenaTier GetRankTier()
		{
			return default(ArenaTier);
		}
	}
}
