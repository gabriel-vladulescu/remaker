using Assets.Scripts.Ssar.Shop.Model;
using Scripts.Config;
using UnityEngine;

namespace SSAR.Shop.View
{
	public class BundlePackagePopupItemView : BasePackView
	{
		private BundlePackageProductInfo productInfo;

		protected override void Start()
		{
		}

		public void Show(BundlePackageProductInfo productInfo)
		{
		}

		public void Hide()
		{
		}

		private bool IsReachLimit()
		{
			return false;
		}

		private int PurchasedCount()
		{
			return 0;
		}

		private BundlePackageBoughtData GetBundlePackageBoughtData()
		{
			return null;
		}

		private void Buy(GameObject o)
		{
		}

		private string GetDescription()
		{
			return null;
		}

		private string GetTextAvailable()
		{
			return null;
		}
	}
}
