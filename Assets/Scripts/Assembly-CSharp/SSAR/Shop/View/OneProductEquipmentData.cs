using Scripts.Config;

namespace SSAR.Shop.View
{
	public class OneProductEquipmentData
	{
		public EquipmentConfigId EquipmentConfigId { get; private set; }

		public RandomEquipment RandomEquipment { get; private set; }

		public OneProductEquipmentData(EquipmentConfigId equipmentConfigId, RandomEquipment randomEquipment)
		{
		}
	}
}
