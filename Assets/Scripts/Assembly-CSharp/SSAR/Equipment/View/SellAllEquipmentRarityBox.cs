using System;
using SSAR.Equipment.Enum;
using UnityEngine;

namespace SSAR.Equipment.View
{
	public class SellAllEquipmentRarityBox : MonoBehaviour
	{
		public Rarity Rarity;

		public UILabel lb_title;

		public UISprite sp_tick;

		public GameObject btn_hitBox;

		public Action<Rarity> onTickBox;

		public Action<Rarity> onUntickBox;

		private bool isTick;

		private void Awake()
		{
		}

		public void Init(Rarity rarity)
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
