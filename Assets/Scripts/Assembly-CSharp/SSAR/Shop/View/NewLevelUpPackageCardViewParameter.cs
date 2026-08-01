using Assets.Scripts.Ssar.Shop.Model;
using Scripts.Config;
using Ssar.Analytics.Metrics.Firebase;
using UnityEngine;

namespace SSAR.Shop.View
{
	public class NewLevelUpPackageCardViewParameter : AbsCardViewParameter
	{
		private ItemLocationId itemLocationId;

		public NewLevelUpPackageCardViewParameter(ItemLocationId itemLocationId)
		{
		}

		public string Title()
		{
			return null;
		}

		public string Icon()
		{
			return null;
		}

		public void OnClick(GameObject o)
		{
		}

		public void OnCustomizeIcon(UISprite spriteIcon)
		{
		}

		private bool HasClaimedAllReward(NewLevelUpPackageBoughtData boughtData, ConfigManager configManager)
		{
			return false;
		}

		private bool HasNewPackageWithLevel(NewLevelUpPackageBoughtData boughtData, ConfigManager configManager)
		{
			return false;
		}

		private void ShowAllPackage(ConfigManager configManager)
		{
		}
	}
}
