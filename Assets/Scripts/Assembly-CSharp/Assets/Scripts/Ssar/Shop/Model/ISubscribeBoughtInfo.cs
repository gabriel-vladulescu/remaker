using System.Collections.Generic;
using Scripts.Config;

namespace Assets.Scripts.Ssar.Shop.Model
{
	public interface ISubscribeBoughtInfo
	{
		string Title();

		IProductInfo ProductInfo();

		int DayCount();

		int DayRemaining(int currentTime);

		int BoughtTime();

		List<ItemInfo> GetListSubscribeItemInfos(int day);

		bool CanClaimRewardSubscriptionPackage(int day);

		bool HasClaimRewardSubscriptionPackage(int day);

		void ClaimInstantly();

		void ClaimDaily(int day);
	}
}
