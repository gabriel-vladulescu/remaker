using System;
using System.Collections.Generic;
using Assets.Scripts.Model;
using SSAR.Equipment.Enum;
using UnityEngine;

namespace Scripts.Ssar.Arena
{
	public class PvPTestCreateEquipment : MonoBehaviour
	{
		public UIPopupList PopupList;

		public UILabel lb_text;

		public UILabel lb_equipmnentType;

		public GameObject btn_close;

		public GameObject btn_create;

		public GameObject btn_ok;

		public PvpTestEquipmentView PvpTestEquipmentView;

		private MainCharacterData mainCharacterData;

		private SlotSelect equipmentType;

		private List<string> petHasGenerate;

		private Action<IItem> callBack;

		private IItem equipmentConfigId;

		private void Awake()
		{
		}

		private void Hide(GameObject go)
		{
		}

		private void Generate(GameObject go)
		{
		}

		private IItem GenerateEquipment(Rarity rarity)
		{
			return null;
		}

		private IItem GeneratePet(Rarity rarity)
		{
			return null;
		}

		private void Ok(GameObject o)
		{
		}

		public void Show(SlotSelect equipmentType, MainCharacterData mainCharacterData, Action<IItem> equipment)
		{
		}
	}
}
