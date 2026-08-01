using Assets.Scripts.Ssar.AnniversaryEvent;

namespace Ssar.Event.EventLogin
{
	public class EventLoginDayLogic : ILoginDayLogic
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
	}
}
