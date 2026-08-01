using UnityEngine;

namespace SSAR.Shop.View
{
	public class ShopBlackFridayPackView : MonoBehaviour
	{
		public UILabel lb_name;

		public UISprite sp_icon;

		public UISprite sp_quality;

		public UILabel lb_priceBase;

		public UILabel lb_priceSaleOff;

		public UILabel lb_quantity;

		public UILabel lb_sale;

		public GameObject btn_purchase;

		public GameObject wg_soldOut;

		private ShopBlackFridayItemData itemData;

		private Material grayScaleMaterial;

		private void Awake()
		{
		}

		private void Bought(GameObject go)
		{
		}

		public void Show(ShopBlackFridayItemData itemData)
		{
		}

		private bool HasBought()
		{
			return false;
		}
	}
}
