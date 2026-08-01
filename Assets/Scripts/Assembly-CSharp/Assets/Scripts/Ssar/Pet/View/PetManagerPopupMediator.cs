using Assets.Scripts.Model;
using Assets.Scripts.Ssar.Signal;
using strange.extensions.mediation.impl;

namespace Assets.Scripts.Ssar.Pet.View
{
	public class PetManagerPopupMediator : Mediator
	{
		[Inject]
		public PetManagerPopup view { get; set; }

		[Inject]
		public OnEquipEquipmentSuccessSignal OnEquipEquipmentSuccessSignal { get; set; }

		[Inject]
		public OnUnequipEquipmentSuccessSignal OnUnequipEquipmentSuccessSignal { get; set; }

		[Inject]
		public OnEnhanceEquipmentSuccessSignal OnEnhanceEquipmentSuccessSignal { get; set; }

		[Inject]
		public OnSellOneEquipmentSuccessSignal OnSellOneEquipmentSuccessSignal { get; set; }

		[Inject]
		public OnLockEquipmentSuccessSignal OnLockEquipmentSuccessSignal { get; set; }

		[Inject]
		public OnUnlockEquipmentSuccessSignal OnUnlockEquipmentSuccessSignal { get; set; }

		[Inject]
		public OnAwakenEquipmentSuccessSignal OnAwakenEquipmentSuccessSignal { get; set; }

		[Inject]
		public ChangeEquipmentInventoryTabSignal ChangeEquipmentInventoryTabSignal { get; set; }

		[Inject]
		public OnSellAllEquipmentSuccessSignal OnSellAllEquipmentSuccessSignal { get; set; }

		[Inject]
		public OnAutoEquipEquipmentSuccessSignal OnAutoEquipEquipmentSuccessSignal { get; set; }

		[Inject]
		public OnUnequipAllEquipmentSuccessSignal OnUnequipAllEquipmentSuccessSignal { get; set; }

		[Inject]
		public ReShowPetManagerPopupSignal ReShowPetManagerPopupSignal { get; set; }

		[Inject]
		public OnBuyTreasureSuccessSignal OnBuyTreasureSuccessSignal { get; set; }

		public override void OnRegister()
		{
		}

		public override void OnRemove()
		{
		}

		private void OnDestroy()
		{
		}

		private void UpdateData(IItem item)
		{
		}

		private void UpdateData()
		{
		}
	}
}
