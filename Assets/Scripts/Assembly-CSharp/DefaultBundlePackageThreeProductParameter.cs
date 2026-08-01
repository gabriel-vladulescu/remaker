using System;
using System.Collections.Generic;
using Scripts.Config;
using Ssar.Analytics.Metrics.Firebase;

public class DefaultBundlePackageThreeProductParameter : AbsShowPackageThreeProductParameter
{
	private readonly List<BundlePackageProductInfo> bundlePackageProductInfos;

	private readonly string category;

	private readonly Action onClose;

	private readonly ItemLocationId itemLocationId;

	public DefaultBundlePackageThreeProductParameter(List<BundlePackageProductInfo> bundlePackageProductInfos, string category, Action onClose, ItemLocationId itemLocationId)
	{
	}

	public override void Close()
	{
	}

	public override List<BundlePackageProductInfo> BundlePackageProductInfos()
	{
		return null;
	}

	public override string Category()
	{
		return null;
	}

	public override ItemLocationId ShownFrom()
	{
		return default(ItemLocationId);
	}

	public override bool EnableNext()
	{
		return false;
	}

	public override void Next()
	{
	}

	public override void Previous()
	{
	}
}
