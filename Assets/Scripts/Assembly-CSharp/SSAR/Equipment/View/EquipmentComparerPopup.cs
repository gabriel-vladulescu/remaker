using Assets.Scripts.Model;
using Assets.Scripts.Ssar.Pet.View;
using SSAR.Equipment.Model;
using SSAR.View;
using UnityEngine;

namespace SSAR.Equipment.View
{
	public class EquipmentComparerPopup : BasePopup
	{
		public GameObject leftContainer;

		public GameObject rightContainer;

		public UIWidget anchor;

		public GameObject resourcesContainer;

		private EquipmentInfoContainer leftEquipmentInfoContainer;

		private EquipmentInfoContainer rightEquipmentInfoContainer;

		private PetInfoContainer leftPetInfoContainer;

		private PetInfoContainer rightPetInfoContainer;

		private AbsItemInfoContainer leftInfo;

		private AbsItemInfoContainer rightInfo;

		private ShowItemComparerParameter parameter;

		private IItem left;

		private IItem right;

		protected override void Awake()
		{
		}

		protected override void OnDisable()
		{
		}

		protected override void onEnable()
		{
		}

		protected override bool EnableBack()
		{
			return false;
		}

		public void Show(ShowItemComparerParameter parameter)
		{
		}

		private bool IsShowLeft()
		{
			return false;
		}

		private AbsItemInfoContainer PickItemInfoContainer(EnhanceItemType type, EquipmentInfoContainer equipmentInfoContainer, PetInfoContainer petInfoContainer)
		{
			return null;
		}

		public void OnEquipEquipment(IItem equipmentCollectData)
		{
		}

		public void OnAutoEquipSuccess()
		{
		}

		public void OnUnequipEquipment(IItem equipmentCollectData)
		{
		}

		public void OnSellEquipment()
		{
		}

		public void OnEnhaneEquipment(IItem equipmentCollectData)
		{
		}

		public void OnLockEquipment(IItem equipmentCollectData)
		{
		}

		public void OnUnlockEquipment(IItem equipmentCollectData)
		{
		}

		private void Reshow()
		{
		}

		private void InitInfoContainer()
		{
		}

		private void CheckHide()
		{
		}

		private void RemoveLeft()
		{
		}

		private void RemoveRight()
		{
		}
	}
}
