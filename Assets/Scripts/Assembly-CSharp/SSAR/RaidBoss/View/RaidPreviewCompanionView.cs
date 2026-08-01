using Assets.Scripts.Ssar.CharacterSelection.View;
using Assets.Scripts.Ssar.Pet.View;
using SSAR.Equipment.Enum;
using SSAR.Equipment.Model;
using SSAR.Equipment.View;
using Scripts.Ssar.Pet;
using UnityEngine;

namespace Ssar.RaidBoss.View
{
	public class RaidPreviewCompanionView : MonoBehaviour
	{
		public UILabel lbTextLv;

		public UILabel lbName;

		public UILabel lbLevel;

		public UILabel lbPower;

		public GameObject modelRoot;

		public GameObject[] slot;

		public GameObject petSlot;

		public CharacterInfoSkillView[] SkillViews;

		private EquipmentSlotView[] slotViews;

		private MainCharacterData mainCharacterData;

		private PetSlotView petSlotView;

		private GameObject model;

		private void Awake()
		{
		}

		private void OnDisable()
		{
		}

		private void InitSlot()
		{
		}

		private void InitPetSlot()
		{
		}

		private void OnClickSlot(EquipmentCollectData collectData, EquipmentType type)
		{
		}

		private void OnClickSlot(PetCollectData collectData)
		{
		}

		private void ReShowModel()
		{
		}

		private EquipmentType[] EquipmentTypes()
		{
			return null;
		}

		internal void Show(MainCharacterData characterData)
		{
		}

		internal void Hide()
		{
		}

		private void ShowEquipment(MainCharacterData mainCharacterData)
		{
		}

		private void ShowPet(MainCharacterData mainCharacterData)
		{
		}

		private void ShowModelPreview(MainCharacterData mainCharacterData)
		{
		}

		private void UpdateSkill(MainCharacterData mainCharacterData)
		{
		}
	}
}
