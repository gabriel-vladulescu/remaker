using System.Collections.Generic;
using Assets.Scripts.Model;
using SSAR.Equipment.Model;
using UnityEngine;

namespace SSAR.Equipment.View
{
	public class AwakenEquipmentInventoryItemView : BaseInventoryItemView
	{
		public UILabel lb_name;

		public UILabel lb_leftTop;

		public UILabel lb_rightTop;

		public UILabel lb_tier;

		public UISprite sp_rarity;

		public UISprite sp_icon;

		public UITable table_rune;

		public UISprite[] skillIcon;

		public GameObject wg_tier;

		public GameObject wg_select;

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

		private void UpdateRune(EquipmentCollectData equipmentCollectData)
		{
		}

		private void PassiveSkillIcon(EquipmentCollectData equipmentCollectData)
		{
		}

		private void ClickItem(GameObject o)
		{
		}

		public void OnRemoveMaterial(IItem equipmentCollectData)
		{
		}

		protected override List<IOverlay> Overlay()
		{
			return null;
		}
	}
}
