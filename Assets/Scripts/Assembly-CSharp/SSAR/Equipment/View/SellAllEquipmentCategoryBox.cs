using System;
using UnityEngine;

namespace SSAR.Equipment.View
{
	public class SellAllEquipmentCategoryBox : MonoBehaviour
	{
		public EquipmentCombinedType Category;

		public UILabel lb_title;

		public UISprite sp_tick;

		public GameObject btn_hitBox;

		public Action<EquipmentCombinedType> onTickBox;

		public Action<EquipmentCombinedType> onUnTickBox;

		private bool isTick;

		private void Awake()
		{
		}

		public void Init(EquipmentCombinedType category)
		{
		}

		public void ClickObject(GameObject o)
		{
		}

		private void ActiveSpriteTick(bool active)
		{
		}

		public void Clear()
		{
		}
	}
}
