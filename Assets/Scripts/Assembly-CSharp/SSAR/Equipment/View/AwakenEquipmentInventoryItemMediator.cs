using Assets.Scripts.Ssar.Signal;
using strange.extensions.mediation.impl;

namespace SSAR.Equipment.View
{
	public class AwakenEquipmentInventoryItemMediator : Mediator
	{
		[Inject]
		public AwakenEquipmentInventoryItemView view { get; set; }

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
