using Assets.Scripts.Ssar.Signal;
using strange.extensions.mediation.impl;

namespace SSAR.Equipment.View
{
	public class SellAllEquipmentPopupMediator : Mediator
	{
		[Inject]
		public SellAllEquipmentPopup view { get; set; }

		[Inject]
		public OnSellAllEquipmentSuccessSignal OnSellAllEquipmentSuccessSignal { get; set; }

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
