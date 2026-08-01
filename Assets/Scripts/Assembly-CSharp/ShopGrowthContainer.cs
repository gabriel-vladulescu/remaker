using System.Collections.Generic;
using SSAR.Shop.View;
using Scripts.Config;

public class ShopGrowthContainer : AbsShopContainer
{
	private List<BundlePackageProductInfo> productInfos;

	protected override void OnAwake()
	{
	}

	protected override void OnShow()
	{
	}

	protected override void OnHide()
	{
	}

	protected override string CardViewPath()
	{
		return null;
	}

	protected override int NumOfRowInstantiate()
	{
		return 0;
	}
}
