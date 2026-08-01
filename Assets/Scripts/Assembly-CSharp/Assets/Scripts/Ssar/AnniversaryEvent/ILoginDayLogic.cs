namespace Assets.Scripts.Ssar.AnniversaryEvent
{
	public interface ILoginDayLogic
	{
		void Init(LoginRewardInfo dayReward);

		bool CanClaim();

		bool HasClaimed();

		bool IsTodayReward();

		void Claim();

		void TestClaim();
	}
}
