using SSAR.Equipment.Enum;
using Scripts.Config;
using Ssar.Craft.Model;

namespace Ssar.Craft
{
	public class ItemExtractionLogic
	{
		private CraftConfig config;

		private ItemType itemType;

		private Rarity rarity;

		public ItemExtractionLogic()
		{
		}

		public ItemExtractionLogic(CraftConfig config, ItemType itemType, Rarity rarity)
		{
		}

		public CraftingMaterial[] Extract()
		{
			return null;
		}

		public CraftingMaterial[] ValidateMaterials(CraftingMaterial[] materials)
		{
			return null;
		}

		private int GetMaxMaterialQuantity(int baseValue)
		{
			return 0;
		}

		private CraftConfig.RarityRate[] FormatRarityRates(CraftConfig.ExtractFormula formula)
		{
			return null;
		}

		private int ComparerMaterial(CraftingMaterial a, CraftingMaterial b)
		{
			return 0;
		}

		private int CompareRarityRate(CraftConfig.RarityRate a, CraftConfig.RarityRate b)
		{
			return 0;
		}
	}
}
