using System.Collections.Generic;
using Scripts.Config;

namespace Assets.Scripts.Ssar.Shop.Model
{
	public interface IShowLevelUpPackagePopupParameter
	{
		IProductInfo ProductInfo();

		List<LevelUpPackageRewardInfo> LevelUpPackageRewardInfos();

		void SendClaimRewardAtLevel(int level);

		bool CanClaimRewardAtLevel(int level);

		bool HasClaimedRewardAtLevel(int level);

		void OnClaimRewardAtLevel(int level);
	}
}
