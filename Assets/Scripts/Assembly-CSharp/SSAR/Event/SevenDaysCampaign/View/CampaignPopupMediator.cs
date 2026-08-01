using Ssar.Event.SevenDaysCampaign.Model;
using strange.extensions.mediation.impl;

namespace Ssar.Event.SevenDaysCampaign.View
{
	public class CampaignPopupMediator : Mediator
	{
		[Inject]
		public CampaignPopup view { get; set; }

		[Inject]
		public UpdateCampaignPopupSignal UpdateSignal { get; set; }

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
