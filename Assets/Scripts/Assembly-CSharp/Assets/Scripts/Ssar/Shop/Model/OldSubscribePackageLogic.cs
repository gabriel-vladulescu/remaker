using System.Collections.Generic;
using Scripts.Config;

namespace Assets.Scripts.Ssar.Shop.Model
{
	public class OldSubscribePackageLogic : ISubscribePackageLogic
	{
		private class OldSubscribeBoughtInfo : ISubscribeBoughtInfo
		{
			private readonly ShopPackProductInfo _productInfo;

			private readonly MainCharacterData _mainCharacterData;

			private readonly ConfigManager _configManager;

			private int dayCount;

			public OldSubscribeBoughtInfo(MainCharacterData mainCharacterData, ConfigManager configManager)
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

			private bool HasClaimRewardSubscriptionPackage(MainCharacterData mainCharacterData, int day)
			{
				return false;
			}

			private bool CanClaimRewardSubscriptionPackage(MainCharacterData mainCharacterData, int day)
			{
				return false;
			}

			private bool HasBoughtSubscriptionPackage(MainCharacterData mainCharacterData)
			{
				return false;
			}
		}

		private AbsCardViewParameter p;

		private MainCharacterData mainCharacterData;

		private ISubscribeBoughtInfo _iSubscribeBoughtInfo;

		public OldSubscribePackageLogic(MainCharacterData mainCharacterData, ConfigManager configManager)
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
