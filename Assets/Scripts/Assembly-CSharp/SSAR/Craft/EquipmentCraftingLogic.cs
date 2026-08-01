using Scripts.Config;
using Ssar.Craft.Model;

namespace Ssar.Craft
{
	public class EquipmentCraftingLogic : ItemCraftingLogic
	{
		private const int CRAFTING_EQUIPMENT_RANDOM_ID = 7777772;

		private const int CRAFTING_ANCIENT_RANDOM_ID = 7777773;

		public EquipmentCraftingLogic(CraftConfig config, CraftableItem craftableItem)
			: base(null, null)
		{
		}

		public override ICollectData Craft()
		{
			return null;
		}
	}
}
