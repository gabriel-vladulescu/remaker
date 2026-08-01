using System;
using SSAR.Equipment.Model;
using SSAR.Equipment.View;
using UnityEngine;

namespace Assets.Scripts.Ssar.Rune.View
{
	public class RuneManagerPopupEquipmentSelectInfo : MonoBehaviour
	{
		public GameObject btn_close;

		public GameObject wg_itemInfo;

		public RuneManagerPopupEquipmentRuneSlot[] Slots;

		private EquipmentCardInfo equipmentCardInfo;

		private EquipmentCollectData equipmentCollectData;

		private Action onClose;

		private void Awake()
		{
		}

		public void ListenerOnClose(Action action)
		{
		}

		public void Hide()
		{
		}

		public void Show(EquipmentCollectData equipmentCollectData)
		{
		}

		private void Init()
		{
		}

		public void UpdateSlotInfo()
		{
		}
	}
}
