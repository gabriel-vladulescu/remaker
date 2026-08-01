using Scripts.Ssar.Arena;

namespace Scripts.Config
{
	public class PromotionRankRewardValue
	{
		public string tier { get; set; }

		public int rank { get; set; }

		public int RankID { get; set; }

		public int cosmeticID { get; set; }

		public int cosmeticQ { get; set; }

		public int equipmentID { get; set; }

		public int equipmentQ { get; set; }

		public int runeID { get; set; }

		public int runeQ { get; set; }

		public int petID { get; set; }

		public int petQ { get; set; }

		public int crystalID { get; set; }

		public int MaterialID { get; set; }

		public int MaterialQ { get; set; }

		public ArenaTier GetRankTier()
		{
			return default(ArenaTier);
		}

		public int GetRankDivision()
		{
			return 0;
		}

		public int GetRankID()
		{
			return 0;
		}
	}
}
