using Assets.Scripts.Ssar.Signal;
using strange.extensions.mediation.impl;

namespace Ssar.Ancient.View
{
	public class AncientEnhanceStatContainerMediator : Mediator
	{
		[Inject]
		public AncientEnhanceStatContainer view { get; set; }

		[Inject]
		public OnAddEnhanceAncientMaterialSignal OnAddEnhanceAncientMaterialSignal { get; set; }

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
