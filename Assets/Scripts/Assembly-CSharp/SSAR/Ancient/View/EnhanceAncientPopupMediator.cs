using Assets.Scripts.Ssar.Signal;
using strange.extensions.mediation.impl;

namespace Ssar.Ancient.View
{
	public class EnhanceAncientPopupMediator : Mediator
	{
		[Inject]
		public EnhanceAncientPopup view { get; set; }

		[Inject]
		public OnEnhanceAncientSuccessSignal OnEnhanceAncientSuccessSignal { get; set; }

		[Inject]
		public OnBuyTreasureSuccessSignal OnBuyTreasureSuccessSignal { get; set; }

		[Inject]
		public UpdateEnhanceAncientPopupSignal UpdateEnhanceAncientPopupSignal { get; set; }

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
