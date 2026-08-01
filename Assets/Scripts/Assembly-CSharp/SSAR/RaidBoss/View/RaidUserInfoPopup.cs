using Assets.Scripts.Ssar.Pet.View;
using SSAR.Equipment.Enum;
using SSAR.Equipment.Model;
using SSAR.Equipment.View;
using Scripts.Ssar.Pet;
using Ssar.RaidBoss.Model;
using UnityEngine;

namespace Ssar.RaidBoss.View
{
	public class RaidUserInfoPopup : BasePopup
	{
		public CharacterSimpleStatView CharacterSimpleStatView;

		public CharacterStatDetail CharacterStatDetail;

		public GameObject modelRoot;

		public GameObject[] slot;

		public GameObject petSlot;

		public GameObject[] ancientSlots;

		public GameObject btn_back;

		public UILabel lbBattleCount;

		public UILabel lbBossKill;

		public UILabel lbPlayTime;

		public GameObject btn_fight;

		public GameObject btn_skill;

		public GameObject btn_mastery;

		private EquipmentSlotView[] slotViews;

		private MainCharacterData mainCharacterData;

		private PetSlotView petSlotView;

		private AncientSlotView[] ancientSlotViews;

		protected override void Awake()
		{
		}

		protected override bool EnableBack()
		{
			return false;
		}

		private void Mastery(GameObject o)
		{
		}

		private void Skill(GameObject o)
		{
		}

		private void Fight(GameObject go)
		{
		}

		private void InitSlot()
		{
		}

		private void InitPetSlot()
		{
		}

		private void InitAncientSlots()
		{
		}

		private void OnClickSlot(EquipmentCollectData collectData, EquipmentType type)
		{
		}

		private void OnClickSlot(PetCollectData collectData)
		{
		}

		private EquipmentType[] EquipmentTypes()
		{
			return null;
		}

		private EquipmentType[] AncientTypes()
		{
			return null;
		}

		internal void Show(MainCharacterData characterData, RaidProgress progress)
		{
		}

		private void ShowRaidStat(RaidProgress progress)
		{
		}

		private void ShowEquipment(MainCharacterData mainCharacterData)
		{
		}

		private void ShowPet(MainCharacterData mainCharacterData)
		{
		}

		private void ShowAncients(MainCharacterData mainCharacterData)
		{
		}

		private void ShowModelPreview(MainCharacterData mainCharacterData)
		{
		}
	}
}
