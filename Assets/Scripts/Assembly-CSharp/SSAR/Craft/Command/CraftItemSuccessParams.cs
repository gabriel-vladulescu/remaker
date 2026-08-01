using System;

namespace Ssar.Craft.Command
{
	public class CraftItemSuccessParams
	{
		public ICollectData collectData;

		public Action callback;

		public CraftItemSuccessParams(ICollectData collectData, Action callback)
		{
		}

		public CraftItemSuccessParams(ICollectData collectData)
		{
		}
	}
}
