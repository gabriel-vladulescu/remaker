using Assets.Scripts.Model;
using UnityEngine;

namespace SSAR.Equipment.View
{
	public class EquipmentInfoAncientEnhanceButton : AbsEquipmentInfoButton
	{
		private IItem equipmentCollectData;

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

		private bool IsAncient(IItem equipmentCollectData)
		{
			return false;
		}
	}
}
