using Assets.Scripts.Ssar.Signal;
using strange.extensions.mediation.impl;

namespace SSAR.Equipment.View
{
	public class AwakenEquipmentStatContainerMediator : Mediator
	{
		[Inject]
		public AwakenEquipmentStatContainer view { get; set; }

		[Inject]
		public OnAddAwakenEquipmentMaterialSignal OnAddAwakenEquipmentMaterialSignal { get; set; }

		[Inject]
		public OnRemoveAwakenEquipmentMaterialSignal OnRemoveAwakenEquipmentMaterialSignal { get; set; }

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
