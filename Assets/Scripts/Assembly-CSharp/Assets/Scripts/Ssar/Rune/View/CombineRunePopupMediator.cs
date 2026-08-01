using Ssar.Rune;
using strange.extensions.mediation.impl;

namespace Assets.Scripts.Ssar.Rune.View
{
	public class CombineRunePopupMediator : Mediator
	{
		[Inject]
		public CombineRunePopup view { get; set; }

		[Inject]
		public OnCombineRuneSuccessSignal OnCombineRuneSuccessSignal { get; set; }

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
