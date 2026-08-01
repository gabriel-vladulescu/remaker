using SSAR.Equipment.Model;
using SSAR.Equipment.View;
using UnityEngine;

namespace Assets.Scripts.Ssar.Pet.View
{
	public class PetManagerInventoryItemView : BaseInventoryItemView
	{
		public UILabel lb_name;

		public UILabel lb_leftTop;

		public UILabel lb_rightTop;

		public UILabel lb_tier;

		public UISprite sp_rarity;

		public UISprite sp_icon;

		public GameObject wg_tier;

		public UITable table_rune;

		public UISprite[] skillIcon;

		public GameObject wg_statDiff;

		private EquipmentCollectData EquipmentCollectData;

		private AwakenLevelView awakenLevelView;

		protected override void Awake()
		{
		}

		private void ClickItem(GameObject go)
		{
		}

		private EquipmentCollectData GetCurrentEquipEquippedWithSlot()
		{
			return null;
		}

		protected override void Start()
		{
		}

		protected override void OnShow(ICollectData collectData)
		{
		}
	}
}
