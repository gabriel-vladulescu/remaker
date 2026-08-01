using System;
using Ssar.Craft.Enum;
using UnityEngine;

namespace Ssar.Craft.View
{
	public class CraftingMaterialInventoryTabView : MonoBehaviour
	{
		public UIToggle toggle;

		public GameObject wg_active;

		public UILabel lb_tab;

		public CraftingMaterialType tabType;

		public Action<CraftingMaterialType> onSelect;

		private void Awake()
		{
		}

		private void Select(GameObject go)
		{
		}

		private void OnChange()
		{
		}

		internal void Init(CraftingMaterialType tabType, Action<CraftingMaterialType> onSelect)
		{
		}

		internal void OnChangeTab(CraftingMaterialType tabType)
		{
		}
	}
}
