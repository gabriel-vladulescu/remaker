using System.Collections.Generic;
using Scripts.Config;

namespace Assets.Scripts.Ssar.Shop.Model
{
	public class NewSubscribePackageLogic : ISubscribePackageLogic
	{
		private class NewSubscribeBoughtInfo : ISubscribeBoughtInfo
		{
			private readonly NewSubscribePackageBoughtData _boughtData;

			private NewSubscribePackageProductInfo productInfo;

			public NewSubscribeBoughtInfo(NewSubscribePackageBoughtData boughtData)
			{
			}

			public string Title()
			{
				return null;
			}

			public IProductInfo ProductInfo()
			{
				return null;
			}

			public int DayCount()
			{
				return 0;
			}

			public int DayRemaining(int currentTime)
			{
				return 0;
			}

			public int BoughtTime()
			{
				return 0;
			}

			public List<ItemInfo> GetListSubscribeItemInfos(int day)
			{
				return null;
			}

			public bool CanClaimRewardSubscriptionPackage(int day)
			{
				return false;
			}

			public bool HasClaimRewardSubscriptionPackage(int day)
			{
				return false;
			}

			public void ClaimInstantly()
			{
			}

			public void ClaimDaily(int day)
			{
			}

			private int Day()
			{
				return 0;
			}

			private bool hasClaimRewardSubscriptionPackage(int day)
			{
				return false;
			}

			private bool canClaimRewardSubscriptionPackage(int day)
			{
				return false;
			}

			private bool HasBoughtSubscriptionPackage()
			{
				return false;
			}
		}

		private readonly MainCharacterData _mainCharacterData;

		private readonly ConfigManager _configManager;

		public NewSubscribePackageLogic(MainCharacterData mainCharacterData, ConfigManager configManager)
		{
		}

		public bool IsBought()
		{
			return false;
		}

		public AbsCardViewParameter CardViewParameter()
		{
			return null;
		}

		public ISubscribeBoughtInfo BoughtInfo()
		{
			return null;
		}
	}
}
