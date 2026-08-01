using SSAR.Equipment.Enum;
using Scripts.Config;

namespace Ssar.Craft.Model
{
	public interface IGetCraftRecipeRule
	{
		void SetRarityFilter(Rarity[] rarities);

		bool IsSuitable(CraftConfig.CraftRecipe recipe);

		int Compare(CraftConfig.CraftRecipe a, CraftConfig.CraftRecipe b);
	}
}
