using SSAR.Equipment.Enum;

namespace Scripts.Ssar.Arena
{
	public static class EquipmentTypeExtension
	{
		public static EquipmentType ToEquipmentType(this SlotSelect c)
		{
			return default(EquipmentType);
		}

		public static SlotSelect ToSlotSelect(this EquipmentType c)
		{
			return default(SlotSelect);
		}
	}
}
