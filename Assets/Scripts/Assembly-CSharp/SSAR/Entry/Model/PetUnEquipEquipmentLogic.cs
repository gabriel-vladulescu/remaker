using Assets.Scripts.Model;
using SSAR.Equipment.Model;
using Scripts.Ssar.Pet;

namespace SSAR.Entry.Model
{
	public class PetUnEquipEquipmentLogic : AbsUnEquipItemLogic
	{
		private readonly EquipmentCollectData equipmentCollectData;

		private readonly PetCollectData petCollectData;

		public PetUnEquipEquipmentLogic(EquipmentCollectData equipmentCollectData, PetCollectData petCollectData)
		{
		}

		public override void UnEquip()
		{
		}

		public override IItem ItemSelect()
		{
			return null;
		}
	}
}
