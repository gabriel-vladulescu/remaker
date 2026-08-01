using Assets.Scripts.Ssar.Signal;
using strange.extensions.mediation.impl;

namespace SSAR.Equipment.View
{
	public class InventoryExpandPopupMediator : Mediator
	{
		[Inject]
		public InventoryExpandPopup popup { get; set; }

		[Inject]
		public OnExpandInventorySuccessSignal OnExpandInventorySuccessSignal { get; set; }

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
