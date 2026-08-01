using SSAR.Equipment.Enum;
using Scripts.Config;

namespace SSAR.Equipment.Model
{
	public class CosmeticGallerySetData : ICosmeticGalleryItemData
	{
		private readonly CosmeticGallerySetInfo _setInfo;

		private bool isValid;

		private EquipmentSetInfo setInfo;

		private BundlePackageProductInfo bundlePackageProductInfo;

		private EquipmentVisualAvailableInfo[] equipmentVisualAvailableInfos;

		public CosmeticGallerySetData(CosmeticGallerySetInfo setInfo, ConfigManager configManager, int groupId, int subId)
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

		private EquipmentVisualAvailableInfo[] EquipmentVisualAvailableInfos(EquipmentSetInfo setInfo, ConfigManager configManager)
		{
			return null;
		}
	}
}
