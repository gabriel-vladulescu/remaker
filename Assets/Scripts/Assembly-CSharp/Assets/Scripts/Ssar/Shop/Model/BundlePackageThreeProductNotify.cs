using System;
using System.Collections.Generic;
using Scripts.Config;

namespace Assets.Scripts.Ssar.Shop.Model
{
	public class BundlePackageThreeProductNotify : AbsBundlePackageProductNotify
	{
		private string category;

		private string[] sceneName;

		public BundlePackageThreeProductNotify(string categopy)
		{
		}

		protected override string GetPackagesCategory()
		{
			return null;
		}

		protected override void OnExcute(List<BundlePackageProductInfo> productInfos, Action onContinue, Action onBreak)
		{
		}

		protected override bool IsOneProduct()
		{
			return false;
		}

		protected override string[] Scene()
		{
			return null;
		}
	}
}
