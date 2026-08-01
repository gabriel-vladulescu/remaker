using Scripts.Config;
using UnityEngine;

namespace SSAR.Shop.View
{
	public class FlashSaleEventEquipmentView : MonoBehaviour
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

		private FlashSaleItemInfo itemInfo;

		private void Awake()
		{
		}

		private void Bought(GameObject go)
		{
		}

		public void Show(FlashSaleItemInfo itemInfo)
		{
		}

		private bool HasBought()
		{
			return false;
		}
	}
}
