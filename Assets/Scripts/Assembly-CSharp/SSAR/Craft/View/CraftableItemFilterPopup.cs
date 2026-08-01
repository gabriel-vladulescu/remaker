using System.Collections.Generic;
using SSAR.Equipment.Enum;
using SSAR.Equipment.View;
using UnityEngine;

namespace Ssar.Craft.View
{
	public class CraftableItemFilterPopup : BasePopup
	{
		public UITable table_rarity;

		public GameObject btn_close;

		public GameObject btn_confirm;

		private List<SellAllEquipmentRarityBox> rarityBoxes;

		private List<Rarity> rarities;

		protected override void Awake()
		{
		}

		protected override bool EnableBack()
		{
			return false;
		}

		private void Confirm(GameObject go)
		{
		}

		private void InitRarityBox()
		{
		}

		private void OnUntickBox(Rarity rarity)
		{
		}

		private void OnTickBox(Rarity rarity)
		{
		}

		private void Clear()
		{
		}

		private void ShowBoxes()
		{
		}

		internal void Show()
		{
		}
	}
}
