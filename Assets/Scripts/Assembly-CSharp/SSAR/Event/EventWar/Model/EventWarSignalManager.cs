namespace Ssar.Event.EventWar.Model
{
	public class EventWarSignalManager
	{
		[Inject]
		public AddEventWarTokenSignal AddEventWarTokenSignal { get; set; }

		[Inject]
		public ShowEventWarPopupSignal ShowEventWarPopupSignal { get; set; }

		[Inject]
		public ClaimEventWarRewardSignal ClaimEventWarRewardSignal { get; set; }
	}
}
