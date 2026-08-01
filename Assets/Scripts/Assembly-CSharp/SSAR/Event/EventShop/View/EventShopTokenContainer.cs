using System.Collections.Generic;
using SSAR.Shop.View;
using Scripts.Config;

namespace Ssar.Event.EventShop.View
{
	public class EventShopTokenContainer : AbsShopContainer
	{
		private List<EventShopTokenProductInfo> productInfos;

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

		private EventShopConfig GetConfig()
		{
			return null;
		}
	}
}
