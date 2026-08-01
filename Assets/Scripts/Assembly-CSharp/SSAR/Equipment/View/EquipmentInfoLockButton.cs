using Assets.Scripts.Model;
using UnityEngine;

namespace SSAR.Equipment.View
{
	public class EquipmentInfoLockButton : AbsEquipmentInfoButton
	{
		public UISprite sp_icon;

		private bool isLock;

		private IItem equipmentCollectData;

		protected override bool IsValid(IItem equipmentCollectData)
		{
			return false;
		}

		protected override void OnShow(IItem equipmentCollectData)
		{
		}

		protected override void OnClickButton(GameObject p)
		{
		}

		private void UpdateData()
		{
		}
	}
}
