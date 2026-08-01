namespace Ssar.Event.EventPopup
{
	public interface IEventData
	{
		int TotalSpent();

		bool CanClaimReward(int productId, int max);

		bool IsReachValue(int max);

		bool IsRewardClaimed(int productId);

		void ClaimReward(int productId, int value);
	}
}
