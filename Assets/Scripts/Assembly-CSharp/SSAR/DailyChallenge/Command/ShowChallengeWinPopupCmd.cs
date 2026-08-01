using Ssar.DailyChallenge.Model;

namespace Ssar.DailyChallenge.Command
{
	public class ShowChallengeWinPopupCmd : BaseShowPopupCmd
	{
		[Inject]
		public ChallengeEndParameters Parameters { get; set; }

		[Inject]
		public ChallengeEndParametersWithDemonInvasion ParametersWithDemon { get; set; }

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

		private bool IsAvailableDemonInvasion()
		{
			return false;
		}

		private void AddRewards(ChallengeEndParametersWithDemonInvasion endParameters)
		{
		}

		private void SaveRank()
		{
		}
	}
}
