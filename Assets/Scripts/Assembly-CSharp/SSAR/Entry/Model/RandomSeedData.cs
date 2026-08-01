using LitJson;

namespace SSAR.Entry.Model
{
	public class RandomSeedData
	{
		[JsonInclude]
		private CraftRandomSeedData craftRandomSeedData;

		[JsonInclude]
		private ShopTreasureRandomSeedData shopTreasureRandomSeedData;

		[JsonInclude]
		private ReforgeRandomSeedData reforgeRandomSeedData;

		[JsonInclude]
		private SalvageItemRandomSeedData salvageItemRandomSeedData;

		[JsonInclude]
		private RewardRandomSeedData rewardRandomSeedData;

		public CraftRandomSeedData GetCraftRandomSeedData()
		{
			return null;
		}

		public ShopTreasureRandomSeedData GetShopTreastureRandomSeedData()
		{
			return null;
		}

		public ReforgeRandomSeedData GetReforgeRandomSeedData()
		{
			return null;
		}

		public SalvageItemRandomSeedData GetSalvageItemRandomSeedData()
		{
			return null;
		}

		public RewardRandomSeedData GetRewardRandomSeedData()
		{
			return null;
		}

		public void SetTimeCreateCharacter(int timeCreateCharacter)
		{
		}
	}
}
