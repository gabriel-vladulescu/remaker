using System;
using Assets.Scripts.Model;
using SSAR.Equipment.View;
using UnityEngine;

namespace Scripts.Ssar.Arena
{
	public class PvpTestEquipmentView : MonoBehaviour
	{
		public SlotSelect type;

		public UILabel lb_tier;

		public UILabel lb_rarity;

		public UILabel lb_enhance;

		public UISprite sp_rarity;

		public UISprite sp_icon;

		public UITable tableRune;

		public UISprite[] sp_rune;

		public UISprite[] sp_passiveSkill;

		public GameObject wg_tier;

		public GameObject btn_add;

		public GameObject btn_remove;

		public Action Rewmove;

		public Action<SlotSelect> OnCreate;

		public Action<IItem> OnShowInfo;

		private AwakenLevelView awakenLevelView;

		private IItem equipmentCollectData;

		private MainCharacterData mainCharacterData;

		private void Awake()
		{
		}

		private void ShowInfo(GameObject go)
		{
		}

		private void Remove(GameObject go)
		{
		}

		private void Add(GameObject go)
		{
		}

		public void Init(SlotSelect type)
		{
		}

		public void Equip(IItem equipmentCollectData, MainCharacterData mainCharacterData)
		{
		}

		public void UnEquip()
		{
		}

		private void ActiveText(bool active)
		{
		}

		public void Disable()
		{
		}

		private void GetEquipmentSlotIconDefault(SlotSelect slotSelect, ref UISprite sp_icon)
		{
		}
	}
}
