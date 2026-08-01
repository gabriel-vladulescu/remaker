using Assets.Scripts.Model;
using UnityEngine;

namespace SSAR.Equipment.View
{
	public class EquipmentInfoEnhanceButton : AbsEquipmentInfoButton
	{
		public UILabel lb_soul;

		public UITable table;

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

		private void UpdateSoul(int level)
		{
		}

		private bool IsAncient(IItem equipmentCollectData)
		{
			return false;
		}
	}
}
