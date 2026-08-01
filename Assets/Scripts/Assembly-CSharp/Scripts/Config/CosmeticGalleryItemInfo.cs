using System.Collections.Generic;
using Assets.Scripts.Ssar.Equipment.Utils;
using SSAR.Equipment.Enum;

namespace Scripts.Config
{
	public class CosmeticGalleryItemInfo : ICosmeticGalleryInfo
	{
		private Dictionary<CosmeticGalleryCategory, bool> dict;

		public int visualId { get; set; }

		public string equipmentType { get; set; }

		public bool enable { get; set; }

		public int bundleProductId { get; set; }

		public int order { get; set; }

		public List<string> category { get; set; }

		public EquipmentType GetEquipmentType()
		{
			return default(EquipmentType);
		}

		public bool HasCategory(CosmeticGalleryCategory category)
		{
			return false;
		}
	}
}
