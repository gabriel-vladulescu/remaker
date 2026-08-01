using Scripts.Config.Stats;

namespace SSAR.Equipment.Model
{
	public interface IAutoEquipEquipmentParameter
	{
		EntityAbilities EntityAbilitiesBefore();

		EntityAbilities EntityAbilitiesAfter();

		void Equip();
	}
}
