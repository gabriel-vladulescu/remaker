using SSAR.Equipment.Model;
using UnityEngine;

namespace SSAR.Equipment.View
{
	public class CosmeticGalleryInventoryItemView : MonoBehaviour
	{
		public UISprite sp_icon;

		public UILabel lb_name;

		public UISprite sp_rarity;

		public UILabel lb_setName;

		public GameObject btn_buy;

		public GameObject btn_try;

		public GameObject wgSelect;

		public UISprite sp_itemType;

		private ICosmeticGalleryItemData itemData;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public void Show(ICosmeticGalleryItemData itemInfo)
		{
		}

		public void Hide()
		{
		}

		public void Buy(GameObject o)
		{
		}

		private void CheckIsSelect()
		{
		}

		private void Try(GameObject o)
		{
		}

		private string GetItemType(CosmeticGalleryItemType itemType)
		{
			return null;
		}
	}
}
