using Scripts.Config;
using UnityEngine;

namespace SSAR.Shop.View
{
	public class ShopBlackFridayItemView : MonoBehaviour
	{
		public UILabel lb_name;

		public UILabel lb_price;

		public UILabel lb_tier;

		public UILabel lb_quantity;

		public UISprite sp_quality;

		public UISprite[] skillIcon;

		public UISprite sp_icon;

		public UISprite sp_currency;

		public UIWidget icon_offset;

		public UITable table_price;

		public GameObject wg_tier;

		public GameObject btn_buy;

		public GameObject wg_icon;

		public GameObject wg_soldout;

		public GameObject btn_info;

		private Material grayScaleMaterial;

		private ShopBlackFridayItemData itemData;

		private ConfigManager configManager;

		private ShopBlackFridayConfig shopBlackFridayConfig;

		private void Awake()
		{
		}

		public void Show(ShopBlackFridayItemData itemData)
		{
		}

		private void UpdateItem(ShopBlackFridayItemData itemData)
		{
		}

		private void UpdatePrice(ShopBlackFridayItemData itemData)
		{
		}

		public void Hide()
		{
		}

		private void Buy(GameObject o)
		{
		}

		private void Purchase()
		{
		}

		private void ViewInfo(GameObject o)
		{
		}
	}
}
