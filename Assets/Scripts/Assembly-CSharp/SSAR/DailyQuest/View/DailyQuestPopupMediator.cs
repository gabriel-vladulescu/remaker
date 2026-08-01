using Assets.Scripts.Ssar.Signal;
using strange.extensions.mediation.impl;

namespace Ssar.DailyQuest.View
{
	public class DailyQuestPopupMediator : Mediator
	{
		[Inject]
		public DailyQuestPopup view { get; set; }

		[Inject]
		public UpdateDailyQuestUISignal UpdateDailyQuestUiSignal { get; set; }

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
