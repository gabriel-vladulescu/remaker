using Assets.Scripts.Ssar.Signal;
using strange.extensions.mediation.impl;

namespace Assets.Scripts.Ssar.Pet.View
{
	public class PetListPopupMediator : Mediator
	{
		[Inject]
		public PetListPopup view { get; set; }

		[Inject]
		public OnSellAllEquipmentSuccessSignal OnSellAllEquipmentSuccessSignal { get; set; }

		[Inject]
		public UpdatePetListInventorySignal UpdatePetListInventorySignal { get; set; }

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
	}
}
