using System;
using System.Collections.Generic;
using Scripts.Config;

namespace Assets.Scripts.Ssar.Shop.Model
{
	public class ShowFirstTimePurchasePackageInfoParameter : AbsShowPackageInfoParameter
	{
		private FirstTimePurchaseProductInfo productInfo;

		private int curIndex;

		private List<FirstTimePurchaseProductInfo> productInfos;

		public ShowFirstTimePurchasePackageInfoParameter(FirstTimePurchaseProductInfo productInfo, List<FirstTimePurchaseProductInfo> productInfos, Action onContinueQueue, Action onBreakQueue)
			: base(null, null)
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

		private int CurIndex()
		{
			return 0;
		}

		private void ChangeInfo(int index)
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
	}
}
