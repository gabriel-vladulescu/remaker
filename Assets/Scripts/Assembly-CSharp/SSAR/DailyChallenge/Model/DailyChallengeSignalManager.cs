namespace Ssar.DailyChallenge.Model
{
	public class DailyChallengeSignalManager
	{
		[Inject]
		public EnterDailyChallengeSignal EnterDailyChallengeSignal { get; set; }

		[Inject]
		public SelectChallengeBuffSignal SelectChallengeBuffSignal { get; set; }

		[Inject]
		public OnSelectChallengeBuffCompletedSignal OnSelectChallengeBuffCompletedSignal { get; set; }

		[Inject]
		public CheckEnterDailyChallengeOfflineSignal CheckEnterDailyChallengeOfflineSignal { get; set; }

		[Inject]
		public UpdateChallengeResultSignal UpdateChallengeResultSignal { get; set; }

		[Inject]
		public ShowChallengeSelectBuffPopupSignal ShowChallengeSelectBuffPopupSignal { get; set; }

		[Inject]
		public ShowDailyChallengePopupSignal ShowDailyChallengePopupSignal { get; set; }

		[Inject]
		public LoadTestDailyChallengeSceneSignal LoadTestDailyChallengeSceneSignal { get; set; }
	}
}
