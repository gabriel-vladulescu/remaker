using System.Collections.Generic;
using Scripts.Config;

namespace Assets.Scripts.Ssar.Shop.Command
{
	public class ShowAllAncientPackageCmd : AbsShowAllPackageCmd
	{
		protected override List<BundlePackageProductInfo> GetProductInfos()
		{
			return null;
		}

		protected override void OnExcute()
		{
		}
	}
}
