using System.Collections.Generic;

namespace Assets.Scripts.Ssar.Shop.Model
{
	public class BundlePackageCategoryInfo
	{
		public string category { get; set; }

		public string localizeName { get; set; }

		public string[] triggers { get; set; }

		public string[] triggers2 { get; set; }

		public string[] triggers3 { get; set; }

		public string showType { get; set; }

		public bool GetBundleTriggerInfo(ref List<BundleTriggerInfo> bundleTriggerInfos, ref List<BundleTriggerInfo> bundleTriggerInfos2, ref List<BundleTriggerInfo> bundleTriggerInfos3)
		{
			return false;
		}

		private bool GetBundleTriggerInfo(string[] trigger, ref List<BundleTriggerInfo> bundleTriggerInfos)
		{
			return false;
		}

		public BundleCategoryType GetBundleCategoryType()
		{
			return default(BundleCategoryType);
		}
	}
}
