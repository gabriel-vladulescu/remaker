using SSAR.Equipment.Enum;
using Scripts.Config;

namespace SSAR.Equipment.Model
{
	public interface ICosmeticGalleryItemData
	{
		bool AllConfigIsValid();

		CosmeticGalleryItemType ItemType();

		string Icon();

		Rarity Rarity();

		string Name();

		string SetName();

		ICosmeticGalleryInfo CosmeticGalleryInfo();

		BundlePackageProductInfo BundlePackageProductInfo();

		EquipmentVisualAvailableInfo[] EquipmentVisualAvailableInfos();
	}
}
