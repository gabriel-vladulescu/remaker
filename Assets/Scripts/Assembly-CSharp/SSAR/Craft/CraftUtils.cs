using Assets.Scripts.Ssar.Equipment;
using SSAR.Equipment.Enum;
using SSAR.Equipment.Model;
using Scripts.Config;
using Ssar.Craft.Enum;
using Ssar.Craft.Model;

namespace Ssar.Craft
{
	public static class CraftUtils
	{
		private static EquipmentTier baseCraftTier;

		public static CraftConfig GetConfig()
		{
			return null;
		}

		public static ItemCraftingLogic GetCraftingLogic(CraftableItem craftableItem)
		{
			return null;
		}

		public static IGetCraftRecipeRule GetCraftRecipeRule(CraftingTabType tabType, Rarity[] rarities)
		{
			return null;
		}

		public static int GetRemaingTime(CraftItemProgress progress, CraftConfig.CraftRecipe recipe)
		{
			return 0;
		}

		public static bool IsEnoughMaterials(CraftableItem craftableItem)
		{
			return false;
		}

		public static int GetCraftCost(CraftableItem craftableItem)
		{
			return 0;
		}

		public static int GetMaterialSellPrice(Rarity rarity, int amount)
		{
			return 0;
		}

		private static int GetPrice(EquipmentType equipmentType, Rarity rarity, float costConstant)
		{
			return 0;
		}

		public static EquipmentDropConfig GetEquipmentDropConfig()
		{
			return null;
		}

		public static StatsConfig GetMainStat(EquipmentType equipmentType, Rarity rarity, EquipmentTier tier)
		{
			return null;
		}

		public static int GetMaxSocket(EquipmentType equipmentType, Rarity rarity)
		{
			return 0;
		}

		public static int[] GetSkillCountRange(EquipmentCollectData collectData)
		{
			return null;
		}

		public static void GetActiveSkillCountRange(EquipmentCollectData collectData, ref int minNumberOfSkill, ref int maxNumberOfSkill)
		{
		}

		public static void GetPassiveSkillCount(EquipmentCollectData collectData, ref int numberOfSkill)
		{
		}

		public static int[] GetSubStatCountRange(EquipmentType equipmentType, Rarity rarity)
		{
			return null;
		}
	}
}
