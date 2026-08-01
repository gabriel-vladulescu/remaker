using System;
using SSAR.Shop.Enum;
using UnityEngine;

namespace SSAR.Shop.View
{
	public class ShopGroupView : MonoBehaviour
	{
		public ShopGroupType groupType;

		public GameObject wgActive;

		public GameObject wgGroup;

		public Action<ShopGroupType> onClick;

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
