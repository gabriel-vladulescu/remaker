using Assets.Scripts.Ssar.CharacterSelection.View;
using Assets.Scripts.Ssar.Dungeon.Model;
using SSAR.Equipment.Enum;
using SSAR.Equipment.View;
using UnityEngine;

namespace Assets.Scripts.Ssar.Dungeon.View
{
	public class PlayerCorpsePopup : BasePopup
	{
		public UILabel lb_name;

		public UILabel lb_level;

		public UILabel btn_pray_desc;

		public UILabel btn_corpse_desc;

		public UILabel lb_title;

		public UILabel lb_masteryLv;

		public GameObject btn_pray;

		public GameObject btn_curse;

		public GameObject btn_close;

		public GameObject[] slot;

		public GameObject[] cosmeticSlot;

		public GameObject wgEquipmentEquipped;

		public GameObject wgCosmeticEquipped;

		public GameObject modelRoot;

		public CharacterInfoSkillView[] SkillViews;

		private GameObject model;

		private EquipmentSlotView[] slotViews;

		private CosmeticSlotView[] cosmeticSlotViews;

		private PlayerCorpseData playerCorpseData;

		protected override void Awake()
		{
		}

		private void Pray(GameObject go)
		{
		}

		private void Curse(GameObject go)
		{
		}

		private void Stop(bool stop)
		{
		}

		protected override void OnDisable()
		{
		}

		protected override void OnDestroy()
		{
		}

		protected override bool EnableBack()
		{
			return false;
		}

		protected override void ExecuteBack()
		{
		}

		public void Show(PlayerCorpseData playerCorpseData)
		{
		}

		private void ShowEquipment(bool equipment)
		{
		}

		private void UpdateInfo()
		{
		}

		private void InitSlot()
		{
		}

		private void InitCosmeticSlot()
		{
		}

		public void UpdateEquipment(MainCharacterData mainCharacterData)
		{
		}

		public void UpdateCosmetic(MainCharacterData mainCharacterData)
		{
		}

		private EquipmentType[] CosmeticTypes()
		{
			return null;
		}

		private EquipmentType[] EquipmentTypes()
		{
			return null;
		}

		private void ShowModelPreview()
		{
		}

		private void UpdateSkill()
		{
		}
	}
}
