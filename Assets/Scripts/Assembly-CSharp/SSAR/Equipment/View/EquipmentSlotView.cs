using System;
using SSAR.Equipment.Enum;
using SSAR.Equipment.Model;
using UnityEngine;
using strange.extensions.mediation.impl;

namespace SSAR.Equipment.View
{
	public class EquipmentSlotView : strange.extensions.mediation.impl.View
	{
		public EquipmentType type;

		public UILabel lb_tier;

		public UILabel lb_rarity;

		public UILabel lb_enhance;

		public UISprite sp_rarity;

		public UISprite sp_icon;

		public UITable tableRune;

		public UISprite[] sp_rune;

		public UISprite[] sp_passiveSkill;

		public GameObject wg_tier;

		public GameObject icon_lock;

		public GameObject wgComingSoon;

		public UISprite sp_changeVisualEnableLeft;

		public UISprite sp_changeVisualEnableRight;

		private EquipmentCollectData equipmentCollectData;

		private bool enableRarityTitle;

		private bool isLock;

		private Action<EquipmentCollectData, EquipmentType> onClick;

		private Action<EquipmentType> onClickEnableVisual;

		private UISprite cuurrentBtnChangeVisual;

		private AwakenLevelView awakenLevelView;

		private MainCharacterData mainCharacterData;

		protected override void Awake()
		{
		}

		protected override void OnEnable()
		{
		}

		public void Init(EquipmentType type, bool isLeft)
		{
		}

		public void Equip(EquipmentCollectData equipmentCollectData, MainCharacterData mainCharacterData, bool isCraftMode = false)
		{
		}

		public void ComingSoon()
		{
		}

		private void PassiveSkillIcon(EquipmentCollectData equipmentCollectData)
		{
		}

		private void UpdateRune(EquipmentCollectData equipmentCollectData)
		{
		}

		public virtual void UnEquip()
		{
		}

		public void DisableRarityTitle()
		{
		}

		public void ListenOnClick(Action<EquipmentCollectData, EquipmentType> action)
		{
		}

		public void Disable()
		{
		}

		private void ActiveText(bool active)
		{
		}

		public void ListenOnClickEnableVisual(Action<EquipmentType> action)
		{
		}

		public void EnableVisual()
		{
		}

		public void DisableVisual()
		{
		}

		private void UpdateBtnEnableVisual()
		{
		}

		public void DisableChangeVisual()
		{
		}

		public void EnableChangeVisual()
		{
		}

		protected virtual void OnClickObject(GameObject o)
		{
		}

		private void InitClickComingSoon()
		{
		}
	}
}
