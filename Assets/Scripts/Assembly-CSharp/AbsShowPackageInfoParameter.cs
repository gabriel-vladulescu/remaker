using System;
using System.Collections.Generic;
using Scripts.Config;

public abstract class AbsShowPackageInfoParameter : ShowPopupNotifyParameter
{
	public AbsShowPackageInfoParameter(Action onContinueQueue, Action onBreakQueue)
		: base(null, null)
	{
	}

	public abstract void OnShow();

	public abstract List<ItemInfo> ItemInfos();

	public abstract IProductInfo ProductInfo();

	public abstract string TextAvailable();

	public abstract void ClickBuy();

	public abstract void ClickNext();

	public abstract void ClickPrevious();

	public abstract string Title();

	public abstract bool EnableShowIcon();

	public abstract int IconHeight();

	public abstract int IconPositionY();

	public abstract string IconName();

	public abstract bool EnableBuy();

	public abstract bool IsLimitedByTime();

	public abstract DateTime GetStartTime();

	public abstract DateTime GetEndTime();
}
