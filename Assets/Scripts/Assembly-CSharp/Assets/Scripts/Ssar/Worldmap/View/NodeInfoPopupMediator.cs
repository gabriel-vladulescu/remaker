using Assets.Scripts.Ssar.Signal;
using strange.extensions.mediation.impl;

namespace Assets.Scripts.Ssar.WorldMap.View
{
	public class NodeInfoPopupMediator : Mediator
	{
		[Inject]
		public OnBuySpecialItemSuccessSignal OnBuySpecialItemSuccessSignal { get; set; }

		[Inject]
		public NodeInfoPopup view { get; set; }

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
