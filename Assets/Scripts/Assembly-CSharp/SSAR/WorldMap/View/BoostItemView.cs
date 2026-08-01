using System;
using UnityEngine;

namespace SSAR.WorldMap.view
{
	public class BoostItemView : MonoBehaviour
	{
		public UISprite sp_bg;

		public UISprite sp_icon;

		public UILabel lb_quantity;

		public GameObject btn_buy;

		public GameObject btn_select;

		public GameObject btn_unselect;

		public GameObject wg_lock;

		public GameObject wg_select;

		private BoostItemCollectData boostItemCollectData;

		public Action<BoostItemType> OnSelect;

		public Action<BoostItemType> OnUnSelect;

		private void Awake()
		{
		}

		public void Show(BoostItemCollectData boostItemCollectData, bool isSelect)
		{
		}

		private void Select(GameObject o)
		{
		}

		private void UnSelect(GameObject o)
		{
		}

		private void ClickLock(GameObject o)
		{
		}
	}
}
