using System.Collections.Generic;
using Scripts.Config;

namespace Assets.Scripts.Ssar.Shop.Model
{
	public class ShowNewLevelUpPackageParameter : IShowLevelUpPackagePopupParameter
	{
		private NewLevelUpPackageProductInfo productInfo;

		private List<LevelUpPackageRewardInfo> rewardInfos;

		public ShowNewLevelUpPackageParameter(NewLevelUpPackageProductInfo productInfo)
		{
		}

		public IProductInfo ProductInfo()
		{
			return null;
		}

		public List<LevelUpPackageRewardInfo> LevelUpPackageRewardInfos()
		{
			return null;
		}

		public void SendClaimRewardAtLevel(int level)
		{
		}

		public bool CanClaimRewardAtLevel(int level)
		{
			return false;
		}

		public bool HasClaimedRewardAtLevel(int level)
		{
			return false;
		}

		public void OnClaimRewardAtLevel(int level)
		{
		}
	}
}
