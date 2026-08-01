using System;
using SSAR.Shop.Enum;
using UnityEngine;

namespace SSAR.Shop.View
{
	public class ShopTreasureTabView : MonoBehaviour
	{
		public ShopTreastureType TabType;

		public GameObject wgActive;

		public Action<ShopTreastureType> onClick;

		private bool isSelect;

		private void Awake()
		{
		}

		private void OnDisable()
		{
		}

		public void Select()
		{
		}

		public void UnSelect()
		{
		}

		public void Click(GameObject o)
		{
		}
	}
}
