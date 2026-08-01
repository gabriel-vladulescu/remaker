namespace Assets.Scripts.Ssar.AnniversaryEvent
{
	public class FirstAnniversaryLoginDayLogic : ILoginDayLogic
	{
		private LoginRewardInfo dayReward;

		public void Init(LoginRewardInfo dayReward)
		{
		}

		public bool CanClaim()
		{
			return false;
		}

		public bool HasClaimed()
		{
			return false;
		}

		public bool IsTodayReward()
		{
			return false;
		}

		public void Claim()
		{
		}

		public void TestClaim()
		{
		}

		private FirstAnniversaryLoginData Data()
		{
			return null;
		}
	}
}
