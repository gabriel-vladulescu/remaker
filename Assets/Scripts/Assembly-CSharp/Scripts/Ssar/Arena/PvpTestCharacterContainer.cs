using System;
using Assets.Scripts.Model;
using Assets.Scripts.Ssar.Pet.View;
using SSAR.Equipment.Enum;
using SSAR.Equipment.View;
using UnityEngine;

namespace Scripts.Ssar.Arena
{
	public class PvpTestCharacterContainer : MonoBehaviour
	{
		public UIInput input_level;

		public UILabel lb_attack;

		public UILabel lb_def;

		public UILabel lb_hp;

		public GameObject model_container;

		public GameObject btn_detail;

		public GameObject next;

		public GameObject previous;

		public GameObject[] equipmentSlot;

		public GameObject[] cosmeticSlot;

		public GameObject petSlot;

		public GameObject btn_selectEquipment;

		public GameObject btn_selectCosmetic;

		public UILabel lb_power;

		public EquipmentInfoContainer EquipmentInfoContainer;

		public PetInfoContainer PetInfoContainer;

		public PvPTestCreateEquipment PvPTestCreateEquipment;

		public CharacterStatDetail CharacterStatDetail;

		public PvpTestSkillContainer PvpTestSkillContainer;

		public GameObject btn_close;

		public GameObject btn_update;

		public GameObject btn_load;

		private GameObject equipmentContainer;

		private GameObject cosmeticContainer;

		public Action<MainCharacterData> OnEditData;

		private PvpTestEquipmentView[] equipment;

		private PvpTestEquipmentView[] cosmetic;

		private PvpTestEquipmentView pet;

		private PvpTestEquipmentView ancient;

		private IItem currentSelect;

		private int groupId;

		private GameObject model;

		private MainCharacterData mainCharacterData;

		private bool selectEquipment;

		private bool isSymmetryLayout;

		private void Awake()
		{
		}

		private int GetEquipmentAwakenExpLevelRequire(IItem item)
		{
			return 0;
		}

		private void LoadData(GameObject o)
		{
		}

		private void Detail(GameObject go)
		{
		}

		public void Init(MainCharacterData mainCharacterData, bool isSymmetryLayout = true)
		{
		}

		public void Reload(MainCharacterData mainCharacterData)
		{
		}

		private void UpdateData(bool generateEequipment = false)
		{
		}

		private void SelectCosmetic(GameObject o)
		{
		}

		private void SelectEquipment(GameObject o)
		{
		}

		private void Previous(GameObject go)
		{
		}

		private void Next(GameObject go)
		{
		}

		private void ShowModel(MainCharacterData mainCharacterData)
		{
		}

		private void GenerateNewCharacter(bool generateEquipemnt = false)
		{
		}

		private void GenerateNewEquipment()
		{
		}

		private void DisplayEquipment()
		{
		}

		private void DisplayPet()
		{
		}

		private void DisplayCosmetic()
		{
		}

		private void UpdateEquipmentContainer()
		{
		}

		private void InitEquipment()
		{
		}

		private void Init(PvpTestEquipmentView pvpTestEquipmentView, SlotSelect slotSelect)
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

		private void ShowInfo(IItem equipmentCollectData)
		{
		}
	}
}
