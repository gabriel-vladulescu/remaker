using Assets.Scripts.Ssar.Signal;
using strange.extensions.mediation.impl;

namespace SSAR.Equipment.View
{
	public class AwakenMaterialContainerMediator : Mediator
	{
		[Inject]
		public OnAddAwakenEquipmentMaterialSignal AddAwakenEquipmentMaterialSignal { get; set; }

		[Inject]
		public AwakenMaterialContainer view { get; set; }

		[Inject]
		public OnRemoveAwakenEquipmentMaterialSignal RemoveAwakenEquipmentMaterialSignal { get; set; }

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
