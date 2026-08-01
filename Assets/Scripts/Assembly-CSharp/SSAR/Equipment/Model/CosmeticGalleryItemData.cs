using SSAR.Equipment.Enum;
using Scripts.Config;

namespace SSAR.Equipment.Model
{
	public class CosmeticGalleryItemData : ICosmeticGalleryItemData
	{
		private readonly CosmeticGalleryItemType _type;

		private readonly CosmeticGalleryItemInfo _itemInfo;

		private EquipmentVisualAvailableInfo equipmentVisualAvailableInfo;

		private bool isValid;

		private string setName;

		private BundlePackageProductInfo productInfo;

		public CosmeticGalleryItemData(CosmeticGalleryItemType type, CosmeticGalleryItemInfo itemInfo, ConfigManager configManager)
		{
		}

		public bool AllConfigIsValid()
		{
			return false;
		}

		public CosmeticGalleryItemType ItemType()
		{
			return default(CosmeticGalleryItemType);
		}

		public string Icon()
		{
			return null;
		}

		public Rarity Rarity()
		{
			return default(Rarity);
		}

		public string Name()
		{
			return null;
		}

		public string SetName()
		{
			return null;
		}

		public ICosmeticGalleryInfo CosmeticGalleryInfo()
		{
			return null;
		}

		public BundlePackageProductInfo BundlePackageProductInfo()
		{
			return null;
		}

		public EquipmentVisualAvailableInfo[] EquipmentVisualAvailableInfos()
		{
			return null;
		}
	}
}
