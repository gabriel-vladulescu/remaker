using SSAR.Equipment.Model;
using Ssar.Craft.Model;
using Ssar.Rune.Model;
using UnityEngine;

namespace Ssar.Craft.View
{
	public class CraftingPreviewItemView : MonoBehaviour
	{
		public UILabel lb_name;

		public UILabel lb_leftTop;

		public UILabel lb_rightTop;

		public UILabel lb_tier;

		public UILabel lb_quantity;

		public UISprite sp_rarity;

		public UISprite sp_icon;

		public GameObject wg_tier;

		private UISprite sp_random;

		private Collider collider;

		private void InitRandomSprite()
		{
		}

		private void Show(EquipmentCollectData collectData)
		{
		}

		private void Show(Ssar.Rune.Model.Rune collectData)
		{
		}

		private void DisableCollider()
		{
		}

		internal void Show(CraftableItem item)
		{
		}

		internal void Hide()
		{
		}
	}
}
