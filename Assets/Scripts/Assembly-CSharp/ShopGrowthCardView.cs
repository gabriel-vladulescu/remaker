using Assets.Scripts.Ssar.Shop.Model;
using Scripts.Config;
using UnityEngine;

public class ShopGrowthCardView : AbsCardViewParameter
{
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
