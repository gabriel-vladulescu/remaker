using Ssar.Rune;
using strange.extensions.mediation.impl;

namespace Assets.Scripts.Ssar.Rune.View
{
	public class DisassembleRunePopupMediator : Mediator
	{
		[Inject]
		public DisassembleRunePopup view { get; set; }

		[Inject]
		public OnDisassembleRuneSuccessSignal OnDisassembleRuneSuccessSignal { get; set; }

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
