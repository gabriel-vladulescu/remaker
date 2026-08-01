using SSAR.Equipment.View;
using UnityEngine;

namespace Assets.Scripts.Ssar.Pet.View
{
	public class PetListInventoryItemView : BaseInventoryItemView
	{
		public UILabel lb_name;

		public UILabel lb_leftTop;

		public UILabel lb_rightTop;

		public UILabel lb_tier;

		public UISprite sp_rarity;

		public UISprite sp_icon;

		public GameObject wg_tier;

		public GameObject wg_inUse;

		private AwakenLevelView awakenLevelView;

		protected override void Awake()
		{
		}

		protected override void OnShow(ICollectData collectData)
		{
		}

		private void ClickItem(GameObject o)
		{
		}
	}
}
