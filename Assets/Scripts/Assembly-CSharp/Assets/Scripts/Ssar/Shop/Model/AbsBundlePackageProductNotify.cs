using System;
using System.Collections.Generic;
using Scripts.Config;

namespace Assets.Scripts.Ssar.Shop.Model
{
	public abstract class AbsBundlePackageProductNotify : AbsPopupNotify
	{
		private interface ITrigger
		{
			bool IsTrigger();
		}

		private class DefaultTrigger : ITrigger
		{
			public bool IsTrigger()
			{
				return false;
			}
		}

		private class DungeonLoseTrigger : ITrigger
		{
			private int dungeonId;

			private BundleTriggerInfo bundleTriggerInfo;

			private DungeonConfig dungeonConfig;

			public DungeonLoseTrigger(int dungeonId, BundleTriggerInfo bundleTriggerInfo, DungeonConfig dungeonConfig)
			{
			}

			public bool IsTrigger()
			{
				return false;
			}
		}

		private class OutOfStockTrigger : ITrigger
		{
			private BundleTriggerInfo bundleTriggerInfo;

			public OutOfStockTrigger(BundleTriggerInfo bundleTriggerInfo)
			{
			}

			public bool IsTrigger()
			{
				return false;
			}
		}

		private class LoginTrigger : ITrigger
		{
			private BundlePackageProductInfo bundlePackageProductInfo;

			public LoginTrigger(BundlePackageProductInfo bundlePackageProductInfo)
			{
			}

			public bool IsTrigger()
			{
				return false;
			}
		}

		private class MainSceneTrigger : ITrigger
		{
			public bool IsTrigger()
			{
				return false;
			}
		}

		private class ShopCardTrigger : ITrigger
		{
			public bool IsTrigger()
			{
				return false;
			}
		}

		private class ShopResourcesTrigger : ITrigger
		{
			public bool IsTrigger()
			{
				return false;
			}
		}

		private class ShopVendorTrigger : ITrigger
		{
			public bool IsTrigger()
			{
				return false;
			}
		}

		private class WorldmapTrigger : ITrigger
		{
			public bool IsTrigger()
			{
				return false;
			}
		}

		private class InventoryTrigger : ITrigger
		{
			public bool IsTrigger()
			{
				return false;
			}
		}

		private class ChestTrigger : ITrigger
		{
			public bool IsTrigger()
			{
				return false;
			}
		}

		private class PetListTrigger : ITrigger
		{
			public bool IsTrigger()
			{
				return false;
			}
		}

		private class TimeTrigger : ITrigger
		{
			private int interval;

			private string category;

			private string playerPrefKeyFormat;

			public TimeTrigger(string category, BundleTriggerInfo bundleTriggerInfo, string playerPrefKeyFormat)
			{
			}

			public bool IsTrigger()
			{
				return false;
			}
		}

		private class RateTrigger : ITrigger
		{
			private int rate;

			private string category;

			public RateTrigger(string category, BundleTriggerInfo bundleTriggerInfo)
			{
			}

			public bool IsTrigger()
			{
				return false;
			}
		}

		private class AvailbleTimeTrigger : ITrigger
		{
			private DateTime from;

			private DateTime to;

			private bool isValid;

			public AvailbleTimeTrigger(BundleTriggerInfo bundleTriggerInfo)
			{
			}

			public bool IsTrigger()
			{
				return false;
			}
		}

		private class LevelTrigger : ITrigger
		{
			private int level;

			public LevelTrigger(BundleTriggerInfo bundleTriggerInfo)
			{
			}

			public bool IsTrigger()
			{
				return false;
			}
		}

		private class GlobalTimeTrigger : ITrigger
		{
			private int interval;

			private string sceneName;

			public GlobalTimeTrigger(BundleTriggerInfo bundleTriggerInfo, string sceneName)
			{
			}

			public bool IsTrigger()
			{
				return false;
			}
		}

		private List<BundlePackageProductInfo> packages;

		protected abstract string GetPackagesCategory();

		protected abstract void OnExcute(List<BundlePackageProductInfo> productInfos, Action onContinue, Action onBreak);

		protected abstract bool IsOneProduct();

		protected abstract string[] Scene();

		public override void Process(Action onContinue, Action onBreak)
		{
		}

		public override bool IsNotify(string sceneName)
		{
			return false;
		}

		private bool Method2(BundlePackageProductInfo productInfo)
		{
			return false;
		}

		private bool ReachedLimit(BundlePackageProductInfo productInfo)
		{
			return false;
		}

		private bool IsTrigger(ShopConfig shopConfig, DungeonConfig dungeonConfig, string sceneName)
		{
			return false;
		}

		private bool IsTrigger(ShopConfig shopConfig, DungeonConfig dungeonConfig, List<BundleTriggerInfo> bundleTriggerInfos, string sceneName)
		{
			return false;
		}

		public static string GetKey(BundlePackageProductInfo productInfo)
		{
			return null;
		}

		public override string[] SceneActive()
		{
			return null;
		}

		protected override void OnShow()
		{
		}
	}
}
