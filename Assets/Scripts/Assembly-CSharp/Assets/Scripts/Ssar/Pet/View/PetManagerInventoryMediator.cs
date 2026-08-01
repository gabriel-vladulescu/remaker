using Assets.Scripts.Ssar.Signal;
using strange.extensions.mediation.impl;

namespace Assets.Scripts.Ssar.Pet.View
{
	public class PetManagerInventoryMediator : Mediator
	{
		[Inject]
		public PetManagerInventoryView view { get; set; }

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
