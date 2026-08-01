using Assets.Scripts.Model;
using UnityEngine;

namespace SSAR.Equipment.View
{
	public class EquipmentInfoSellButton : AbsEquipmentInfoButton
	{
		public UILabel lb_value;

		public UITable table;

		private IItem equipmentCollectData;

		private int price;

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

		public void UpdateValue(int value)
		{
		}
	}
}
