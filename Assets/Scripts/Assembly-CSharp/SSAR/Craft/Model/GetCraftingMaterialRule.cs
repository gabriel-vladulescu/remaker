using SSAR.Equipment.View;

namespace Ssar.Craft.Model
{
	public class GetCraftingMaterialRule : IGetCollectDataRule
	{
		public bool IsSuitableConditions(ICollectData collectData)
		{
			return false;
		}
	}
}
