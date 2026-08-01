using Assets.Scripts.Ssar.Signal;
using strange.extensions.mediation.impl;

namespace SSAR.Equipment.View
{
	public class EquipmentInfoContainerMediator : Mediator
	{
		[Inject]
		public EquipmentInfoContainer view { get; set; }

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
