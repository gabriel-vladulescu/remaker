using Assets.Scripts.Ssar.Signal;
using strange.extensions.mediation.impl;

namespace Ssar.Craft.View
{
	public class CraftingEquipmentInventoryMediator : Mediator
	{
		[Inject]
		public CraftingInventoryView view { get; set; }

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
