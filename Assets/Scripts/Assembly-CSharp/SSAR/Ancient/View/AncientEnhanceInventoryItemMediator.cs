using Assets.Scripts.Ssar.Signal;
using strange.extensions.mediation.impl;

namespace Ssar.Ancient.View
{
	public class AncientEnhanceInventoryItemMediator : Mediator
	{
		[Inject]
		public AncientEnhanceInventoryItemView view { get; set; }

		[Inject]
		public OnRemoveEnhanceAncientMaterialSignal OnRemoveEnhanceAncientMaterialSignal { get; set; }

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
