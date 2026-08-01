namespace Ssar.DailyChallenge.Command
{
	public class ShowChallengeSelectBuffPopupCmd : BaseShowPopupCmd
	{
		[Inject]
		public ChallengeSelectBuffPopupParameters Parameters { get; set; }

		public override void Execute()
		{
		}

		protected override string GetAssetPath()
		{
			return null;
		}

		protected override string GetInjectName()
		{
			return null;
		}

		protected override PopupCamera GetCamera()
		{
			return default(PopupCamera);
		}
	}
}
