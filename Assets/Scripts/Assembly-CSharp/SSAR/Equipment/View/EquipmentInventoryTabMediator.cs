using Assets.Scripts.Ssar.Signal;
using strange.extensions.mediation.impl;

namespace SSAR.Equipment.View
{
	public class EquipmentInventoryTabMediator : Mediator
	{
		[Inject]
		public EquipmentInventoryTabView view { get; set; }

		[Inject]
		public ChangeEquipmentInventoryTabSignal ChangeEquipmentInventoryTabSignal { get; set; }

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
