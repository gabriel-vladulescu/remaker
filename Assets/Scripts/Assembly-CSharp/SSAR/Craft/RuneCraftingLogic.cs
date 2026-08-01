using Scripts.Config;
using Ssar.Craft.Model;

namespace Ssar.Craft
{
	public class RuneCraftingLogic : ItemCraftingLogic
	{
		public RuneCraftingLogic(CraftConfig config, CraftableItem craftableItem)
			: base(null, null)
		{
		}

		public override ICollectData Craft()
		{
			return null;
		}
	}
}
