using strange.extensions.mediation.impl;

namespace SSAR.View
{
	public class BackgroundPopupMediator : Mediator
	{
		[Inject]
		public BackgroundPopup view { get; set; }
	}
}
