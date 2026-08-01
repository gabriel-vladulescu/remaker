using SSAR.Equipment.Model;
using Ssar.Reforge.Enum;

namespace Ssar.Reforge.Command
{
	public class ShowReforgeResultConfirmParameter
	{
		public readonly EquipmentCollectData originalEquipment;

		public readonly EquipmentCollectData reforgedEquipment;

		public readonly ReforgeType reforgeType;

		public readonly bool enableKeep;

		public ShowReforgeResultConfirmParameter(EquipmentCollectData originalEquipment, EquipmentCollectData reforgedEquipment, ReforgeType reforgeType, bool enableKeep)
		{
		}
	}
}
