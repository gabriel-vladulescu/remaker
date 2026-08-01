using SSAR.Equipment.Enum;
using Scripts.Config;

namespace Ssar.Craft.Model
{
	public class GetWeaponCraftRecipeRule : IGetCraftRecipeRule
	{
		private Rarity[] rarities;

		public void SetRarityFilter(Rarity[] rarities)
		{
		}

		public bool IsSuitable(CraftConfig.CraftRecipe recipe)
		{
			return false;
		}

		public int Compare(CraftConfig.CraftRecipe a, CraftConfig.CraftRecipe b)
		{
			return 0;
		}

		private bool IsMatchedRarity(Rarity rarity)
		{
			return false;
		}
	}
}
