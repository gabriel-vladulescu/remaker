using System.Collections.Generic;
using Scripts.Config;
using Ssar.Analytics.Metrics.Firebase;

public abstract class AbsShowPackageThreeProductParameter
{
	public abstract void Close();

	public abstract List<BundlePackageProductInfo> BundlePackageProductInfos();

	public abstract string Category();

	public abstract ItemLocationId ShownFrom();

	public abstract bool EnableNext();

	public abstract void Next();

	public abstract void Previous();
}
