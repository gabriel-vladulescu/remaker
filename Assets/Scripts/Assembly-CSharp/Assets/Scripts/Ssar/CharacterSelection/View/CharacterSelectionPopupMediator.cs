using Assets.Scripts.Ssar.Signal;
using strange.extensions.mediation.impl;

namespace Assets.Scripts.Ssar.CharacterSelection.View
{
	public class CharacterSelectionPopupMediator : Mediator
	{
		[Inject]
		public CharacterSelectionPopup view { get; set; }

		[Inject]
		public OnCreateCharacterSuccessSignal OnCreateCharacterSuccessSignal { get; set; }

		[Inject]
		public ShowCharacterSelectionPopupSignal ShowCharacterSelectionPopupSignal { get; set; }

		[Inject]
		public OnDeleteCharacterSuccessSignal OnDeleteCharacterSuccessSignal { get; set; }

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
