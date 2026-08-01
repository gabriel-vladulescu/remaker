using SSAR.Equipment.Model;
using UnityEngine;

namespace Assets.Scripts.Ssar.Rune.View
{
	public class RuneManagerPopupEquipmentRuneSlot : MonoBehaviour
	{
		public UISprite sp_icon;

		public UILabel lb_desc;

		public UISprite sp_bg;

		public GameObject btn_remove;

		private int slot;

		private EquipmentCollectData equipmentCollectData;

		private RuneSlot runeSlot;

		private void Awake()
		{
		}

		public void Show(EquipmentCollectData equipmentCollectData, int slot)
		{
		}

		public void Hide()
		{
		}

		private void Remove(GameObject o)
		{
		}
	}
}
