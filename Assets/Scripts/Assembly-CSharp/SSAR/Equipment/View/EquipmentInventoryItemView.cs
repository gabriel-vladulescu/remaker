using SSAR.Equipment.Model;
using UnityEngine;

namespace SSAR.Equipment.View
{
	public class EquipmentInventoryItemView : BaseInventoryItemView
	{
		public UILabel lb_name;

		public UILabel lb_leftTop;

		public UILabel lb_rightTop;

		public UILabel lb_tier;

		public UISprite sp_rarity;

		public UISprite sp_icon;

		public UITable table_rune;

		public GameObject wg_statDiff;

		public UISprite[] skillIcon;

		public GameObject wg_tier;

		private EquipmentCollectData EquipmentCollectData;

		private AwakenLevelView awakenLevelView;

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		protected override void OnShow(ICollectData collectData)
		{
		}

		public static void UpdateRune(EquipmentCollectData equipmentCollectData, UITable table_rune)
		{
		}

		public static void PassiveSkillIcon(EquipmentCollectData equipmentCollectData, UISprite[] skillIcon)
		{
		}

		public static void DisableRune(UITable table_rune)
		{
		}

		public static void DisableSkillIcon(UISprite[] skillIcon)
		{
		}

		private void DisableStatDiff()
		{
		}

		private void ClickItem(GameObject o)
		{
		}

		public static void CheckAndShowStatDiff(EquipmentCollectData equipmentCollectData, EquipmentCollectData equippedCollectData, GameObject wg_statDiff)
		{
		}

		public EquipmentCollectData GetEquipmentCollectData()
		{
			return null;
		}
	}
}
