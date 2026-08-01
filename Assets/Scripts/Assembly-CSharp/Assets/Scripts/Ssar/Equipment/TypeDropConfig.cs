using SSAR.Equipment.Enum;

namespace Assets.Scripts.Ssar.Equipment
{
	public interface TypeDropConfig
	{
		EquipmentType Type();

		float DropRate();
	}
}
