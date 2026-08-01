using System.Collections.Generic;
using SSAR.Equipment.Enum;
using Scripts.Config;

namespace Scripts.Ssar.Pet
{
	public class GeneratePetLogic
	{
		private readonly PetGenerationConfig petGenerationConfig;

		private readonly PetVisualConfig petVisualConfig;

		public GeneratePetLogic(PetGenerationConfig petGenerationConfig, PetVisualConfig petVisualConfig)
		{
		}

		public PetConfigId Generate(int randomPetId, RandomPetConfig randomPetConfig, int visualIdPrefer = -1)
		{
			return null;
		}

		public PetConfigId Generate(RarityDropPercentage[] rarityDropPercentages, TierDropPercentage[] tierDropPercentages, string visualCategory, int visualIdPrefer = -1)
		{
			return null;
		}

		public PetConfigId Generate(RarityDropPercentage[] rarityDropPercentages, TierDropPercentage[] tierDropPercentages, int visualIdPrefer = -1)
		{
			return null;
		}

		private Rarity GenerateRarity(RarityDropPercentage[] rarityDropPercentages)
		{
			return default(Rarity);
		}

		private EquipmentTier GenerateTier(TierDropPercentage[] tierDropPercentages)
		{
			return default(EquipmentTier);
		}

		private List<PetStat> GenerateMainStat(Rarity rarity, EquipmentTier tier)
		{
			return null;
		}

		private List<PetStat> GenerateBonusStats(Rarity rarity)
		{
			return null;
		}

		private List<PetShareStat> GenerateShareStats(Rarity rarity)
		{
			return null;
		}

		private void SeperateShareStat(Rarity rarity, out List<ShareStatValue> statAlwayHas, out List<ShareStatValue> statRandom)
		{
			statAlwayHas = null;
			statRandom = null;
		}

		private List<string> GetVisualCategoryWithRarity(Rarity rarity)
		{
			return null;
		}

		private int GenerateVisualId(Rarity rarity, string visualCategory, int visualIdPrefer)
		{
			return 0;
		}

		private int Round()
		{
			return 0;
		}
	}
}
