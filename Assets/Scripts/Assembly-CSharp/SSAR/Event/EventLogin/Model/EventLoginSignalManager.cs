namespace Ssar.Event.EventLogin.Model
{
	public class EventLoginSignalManager
	{
		[Inject]
		public ShowEventLoginPopupSignal ShowEventLoginPopupSignal { get; set; }

		[Inject]
		public ClaimEventLoginRewardSignal ClaimEventLoginRewardSignal { get; set; }
	}
}
