using System.Collections.Generic;
using UnityEngine;

namespace SSAR.Shop.View
{
	public class AncientEquipmentPackageItemContainer : MonoBehaviour
	{
		public UITable table;

		public UITable table_random;

		private List<AncientEquipmentPackageItemView> itemViews;

		private List<AncientEquipmentPackageRandomItem> randomItems;

		private void Awake()
		{
		}

		public void Show(List<ItemInfo> rewardInfos)
		{
		}
	}
}
