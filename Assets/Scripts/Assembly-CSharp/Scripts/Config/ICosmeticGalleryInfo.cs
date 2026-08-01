using System.Collections.Generic;
using Assets.Scripts.Ssar.Equipment.Utils;

namespace Scripts.Config
{
	public interface ICosmeticGalleryInfo
	{
		bool enable { get; set; }

		int bundleProductId { get; set; }

		int order { get; set; }

		List<string> category { get; set; }

		bool HasCategory(CosmeticGalleryCategory category);
	}
}
