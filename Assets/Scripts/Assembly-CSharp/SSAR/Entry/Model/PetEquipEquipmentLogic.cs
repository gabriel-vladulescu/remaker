using Assets.Scripts.Model;
using SSAR.Equipment.Model;
using Scripts.Ssar.Pet;

namespace SSAR.Entry.Model
{
	public class PetEquipEquipmentLogic : AbsEquipItemLogic
	{
		private readonly EquipmentCollectData equipmentCollectData;

		private readonly PetCollectData petCollectData;

		public PetEquipEquipmentLogic(EquipmentCollectData equipmentCollectData, PetCollectData petCollectData)
		{
		}

		public override void Equip()
		{
		}

		public override IItem ItemSelect()
		{
			return null;
		}
	}
}
