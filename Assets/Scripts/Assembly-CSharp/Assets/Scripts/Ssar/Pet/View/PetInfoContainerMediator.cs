using Assets.Scripts.Ssar.Signal;
using strange.extensions.mediation.impl;

namespace Assets.Scripts.Ssar.Pet.View
{
	public class PetInfoContainerMediator : Mediator
	{
		[Inject]
		public PetInfoContainer view { get; set; }

		[Inject]
		public OnLockEquipmentSuccessSignal OnLockEquipmentSuccessSignal { get; set; }

		[Inject]
		public OnUnlockEquipmentSuccessSignal OnUnlockEquipmentSuccessSignal { get; set; }

		[Inject]
		public OnEnhanceEquipmentSuccessSignal OnEnhanceEquipmentSuccessSignal { get; set; }

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
