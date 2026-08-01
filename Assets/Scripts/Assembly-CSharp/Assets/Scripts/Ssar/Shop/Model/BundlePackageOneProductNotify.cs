using System;
using System.Collections.Generic;
using Scripts.Config;

namespace Assets.Scripts.Ssar.Shop.Model
{
	public class BundlePackageOneProductNotify : AbsBundlePackageProductNotify
	{
		private string category;

		private string[] sceneName;

		public BundlePackageOneProductNotify(string category)
		{
		}

		protected override void OnExcute(List<BundlePackageProductInfo> productInfos, Action onContinue, Action onBreak)
		{
		}

		protected override string GetPackagesCategory()
		{
			return null;
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
