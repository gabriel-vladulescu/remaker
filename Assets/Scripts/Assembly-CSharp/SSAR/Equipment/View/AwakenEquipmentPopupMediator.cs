using Assets.Scripts.Ssar.Signal;
using strange.extensions.mediation.impl;

namespace SSAR.Equipment.View
{
	public class AwakenEquipmentPopupMediator : Mediator
	{
		[Inject]
		public AwakenEquipmentPopup view { get; set; }

		[Inject]
		public OnAwakenEquipmentSuccessSignal OnAwakenEquipmentSuccessSignal { get; set; }

		[Inject]
		public HideAwakenEquipmentPopupSignal HideAwakenEquipmentPopupSignal { get; set; }

		[Inject]
		public UpdateAwakenEquipmentPopupSignal UpdateAwakenEquipmentPopupSignal { get; set; }

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
