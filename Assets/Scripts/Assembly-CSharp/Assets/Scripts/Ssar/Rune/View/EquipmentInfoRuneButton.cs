using Assets.Scripts.Model;
using SSAR.Equipment.Model;
using SSAR.Equipment.View;
using UnityEngine;

namespace Assets.Scripts.Ssar.Rune.View
{
	public class EquipmentInfoRuneButton : AbsEquipmentInfoButton
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

		private bool IsCosmetic(EquipmentCollectData equipmentCollectData)
		{
			return false;
		}
	}
}
