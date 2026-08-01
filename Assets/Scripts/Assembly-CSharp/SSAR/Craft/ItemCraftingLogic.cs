using Scripts.Config;
using Ssar.Craft.Model;

namespace Ssar.Craft
{
	public abstract class ItemCraftingLogic
	{
		protected CraftConfig config;

		protected CraftableItem craftableItem;

		public ItemCraftingLogic(CraftConfig config, CraftableItem craftableItem)
		{
		}

		public abstract ICollectData Craft();

		public CraftingMaterial[] GetRequiredMaterials()
		{
			return null;
		}

		public int GetSoulCost()
		{
			return 0;
		}
	}
}
