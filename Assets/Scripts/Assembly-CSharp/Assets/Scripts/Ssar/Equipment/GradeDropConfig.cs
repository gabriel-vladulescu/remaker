using SSAR.Equipment.Enum;

namespace Assets.Scripts.Ssar.Equipment
{
	public interface GradeDropConfig
	{
		EquipmentTier Grade();

		float DropRate();
	}
}
