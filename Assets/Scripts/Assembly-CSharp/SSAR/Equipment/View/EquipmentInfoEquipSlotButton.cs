using Assets.Scripts.Model;
using SSAR.Equipment.Model;
using UnityEngine;

namespace SSAR.Equipment.View
{
	public class EquipmentInfoEquipSlotButton : AbsEquipmentInfoButton
	{
		public SlotType slotType;

		public UILabel label;

		private IItem equipmentCollectData;

		public void Init(SlotType slotType)
		{
		}

		protected override void OnShow(IItem equipmentCollectData)
		{
		}

		protected override void OnClickButton(GameObject p)
		{
		}

		protected override bool IsValid(IItem equipmentCollectData)
		{
			return false;
		}

		private bool IsAncient(EquipmentCollectData equipmentCollectData)
		{
			return false;
		}

		private bool IsSameAncientSkillAlreadyEquipped(EquipmentCollectData equipmentCollectData)
		{
			return false;
		}

		private void ShowError(string message = "CANT_EQUIP")
		{
		}
	}
}
