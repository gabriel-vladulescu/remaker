using SSAR.Equipment.Model;
using Ssar.Reforge.Enum;

namespace Ssar.Reforge.Command
{
	public class ReforgeConfirmTakeNewEquipmentParameter
	{
		public readonly EquipmentCollectData originalEquipment;

		public readonly EquipmentCollectData reforgedEquipment;

		public readonly ReforgeType reforgeType;

		public ReforgeConfirmTakeNewEquipmentParameter(EquipmentCollectData originalEquipment, EquipmentCollectData reforgedEquipment, ReforgeType reforgeType)
		{
		}
	}
}
