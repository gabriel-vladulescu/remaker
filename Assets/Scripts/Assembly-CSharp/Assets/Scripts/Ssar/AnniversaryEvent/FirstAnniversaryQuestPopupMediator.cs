using Assets.Scripts.Ssar.Signal;
using strange.extensions.mediation.impl;

namespace Assets.Scripts.Ssar.AnniversaryEvent
{
	public class FirstAnniversaryQuestPopupMediator : Mediator
	{
		[Inject]
		public FirstAnniversaryQuestPopup view { get; set; }

		[Inject]
		public UpdateFirstAnniversaryQuestpopupSignal UpdateFirstAnniversaryQuestpopupSignal { get; set; }

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
