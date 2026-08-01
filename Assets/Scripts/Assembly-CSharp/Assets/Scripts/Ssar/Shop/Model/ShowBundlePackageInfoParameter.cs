using System;
using System.Collections.Generic;
using SSAR.Shop.Enum;
using Scripts.Config;
using Ssar.Analytics.Metrics;

namespace Assets.Scripts.Ssar.Shop.Model
{
	public class ShowBundlePackageInfoParameter : AbsShowPackageInfoParameter
	{
		private BundlePackageProductInfo productInfo;

		private string category;

		private string shownFrom;

		private Metric metric;

		private ConfigManager configManager;

		private ShopConfig shopConfig;

		private int curIndex;

		private ShopTabType shopTabType;

		private List<BundlePackageProductInfo> allPack;

		private const string ANCIENT = "ancient";

		private const string SHOP_BLACK_FRIDAY = "shopblackfriday";

		public ShowBundlePackageInfoParameter(BundlePackageProductInfo productInfo, string category, string shownFrom, Action onContinueQueue, Action onBreakQueue, ShopTabType shopTabType = ShopTabType.None)
			: base(null, null)
		{
		}

		public ShowBundlePackageInfoParameter SetListPackages(List<BundlePackageProductInfo> packages)
		{
			return null;
		}

		private void SendShowPackageBundleMetric()
		{
		}

		public override void OnShow()
		{
		}

		public override List<ItemInfo> ItemInfos()
		{
			return null;
		}

		public override IProductInfo ProductInfo()
		{
			return null;
		}

		public override string TextAvailable()
		{
			return null;
		}

		public override void ClickBuy()
		{
		}

		public override void ClickNext()
		{
		}

		public override void ClickPrevious()
		{
		}

		public override string Title()
		{
			return null;
		}

		public override bool EnableShowIcon()
		{
			return false;
		}

		public override int IconHeight()
		{
			return 0;
		}

		public override int IconPositionY()
		{
			return 0;
		}

		public override string IconName()
		{
			return null;
		}

		public override bool EnableBuy()
		{
			return false;
		}

		public bool IsReachedLimit()
		{
			return false;
		}

		public bool IsEnableBuyLimit()
		{
			return false;
		}

		public int BuyLimitCount()
		{
			return 0;
		}

		public int PurchasedCount()
		{
			return 0;
		}

		public override bool IsLimitedByTime()
		{
			return false;
		}

		public override DateTime GetStartTime()
		{
			return default(DateTime);
		}

		public override DateTime GetEndTime()
		{
			return default(DateTime);
		}

		private BundlePackageBoughtData GetBundlePackageBoughtData()
		{
			return null;
		}

		private int GetCurIndex()
		{
			return 0;
		}

		private void ChangeInfo(int newIndex)
		{
		}

		private BundlePackageProductInfo GetBundlePackageProductInfo(int index)
		{
			return null;
		}
	}
}
