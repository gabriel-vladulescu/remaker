using System;
using Ssar.Craft.Enum;
using Ssar.Craft.Model;
using UnityEngine;

namespace Ssar.Craft.View
{
	public class CraftingMaterialInfoView : MonoBehaviour
	{
		public GameObject wg_item;

		public GameObject btn_close;

		public GameObject btn_ok;

		public GameObject btn_sell;

		public UILabel lb_info;

		private CraftingMaterial craftingMaterial;

		private CraftingMaterialView materialView;

		private Action onClose;

		private void Awake()
		{
		}

		private void Init()
		{
		}

		private void Close(GameObject go)
		{
		}

		private void Sell(GameObject go)
		{
		}

		private void ShowInfo()
		{
		}

		public void Show(CraftingMaterial material, ViewMaterialInfoType viewType)
		{
		}

		public void AddListenerOnClose(Action action)
		{
		}
	}
}
