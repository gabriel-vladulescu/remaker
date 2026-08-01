using strange.extensions.mediation.impl;

namespace SSAR.Equipment.View
{
	public class EquipmentSlotMediator : Mediator
	{
		[Inject]
		public EquipmentSlotView view { get; set; }

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
