namespace Ssar.Event.DemonInvasion.Model
{
	public class DemonInvasionSignalManager
	{
		[Inject]
		public ShowMainDemonPopupSignal ShowMainDemonPopupSignal { get; set; }

		[Inject]
		public ShowDemonRewardPopupSignal ShowDemonRewardPopupSignal { get; set; }

		[Inject]
		public ShowDemonPassPopupSignal ShowDemonPassPopupSignal { get; set; }

		[Inject]
		public ShowDemonDailyLoginSignal ShowDemonDailyLoginSignal { get; set; }

		[Inject]
		public OnClaimDailySignal OnClaimDailySignal { get; set; }

		[Inject]
		public OnClaimRewardSignal OnClaimRewardSignal { get; set; }

		[Inject]
		public OnBuyDemonPassSignal OnBuyDemonPassSignal { get; set; }

		[Inject]
		public UnlockDemonPassSignal UnlockDemonPassSignal { get; set; }

		[Inject]
		public AddEventDemonTokenSignal AddEventDemonTokenSignal { get; set; }

		[Inject]
		public OnClaimDailySuccessSignal OnClaimDailySuccessSignal { get; set; }

		[Inject]
		public OnClaimRewardSuccessSignal OnClaimRewardSuccessSignal { get; set; }

		[Inject]
		public UnlockDemonPassSuccessSignal UnlockDemonPassSuccessSignal { get; set; }

		[Inject]
		public AddEventDemonTokenSuccessSignal AddEventDemonTokenSuccessSignal { get; set; }
	}
}
