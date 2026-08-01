using Assets.Scripts.Model;
using UnityEngine;

namespace SSAR.Equipment.View
{
	public class EquipmentInfoRemoveButton : AbsEquipmentInfoButton
	{
		private IItem equipmentCollectData;

		protected override void OnShow(IItem equipmentCollectData)
		{
		}

		protected override bool IsValid(IItem equipmentCollectData)
		{
			return false;
		}

		protected override void OnClickButton(GameObject p)
		{
		}
	}
}
