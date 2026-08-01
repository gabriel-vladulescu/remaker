using Assets.Scripts.Ssar.Pet.View;
using SSAR.BattleSystem.System.Arena.Api;
using SSAR.Equipment.Enum;
using SSAR.Equipment.Model;
using SSAR.Equipment.View;
using Scripts.Ssar.Pet;
using UnityEngine;

namespace Scripts.Ssar.Arena
{
	public class UserInfoPopup : BasePopup
	{
		public CharacterSimpleStatView CharacterSimpleStatView;

		public CharacterStatDetail CharacterStatDetail;

		public GameObject modelRoot;

		public GameObject[] slot;

		public GameObject petSlot;

		public GameObject[] ancientSlots;

		public GameObject btn_back;

		public UILabel lb_seasonParticipation;

		public UILabel lb_seasonWinning;

		public UILabel lb_seasonPLayedTime;

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

		public void Show(MainCharacterData mainCharacterData, UserSeasonProgress userSeasonProgress)
		{
		}

		private void ShowArenaStat(UserSeasonProgress userSeasonProgress)
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

		private EquipmentType[] AncientTypes()
		{
			return null;
		}

		private EquipmentType[] EquipmentTypes()
		{
			return null;
		}
	}
}
