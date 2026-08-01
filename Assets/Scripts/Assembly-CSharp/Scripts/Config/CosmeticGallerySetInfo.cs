using System.Collections.Generic;
using Assets.Scripts.Ssar.Equipment.Utils;

namespace Scripts.Config
{
	public class CosmeticGallerySetInfo : ICosmeticGalleryInfo
	{
		private Dictionary<CosmeticGalleryCategory, bool> dict;

		public string name { get; set; }

		public int setId { get; set; }

		public bool enable { get; set; }

		public int bundleProductId { get; set; }

		public int order { get; set; }

		public List<string> category { get; set; }

		public bool HasCategory(CosmeticGalleryCategory category)
		{
			return false;
		}
	}
}
