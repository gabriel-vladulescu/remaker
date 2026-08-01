using Assets.Scripts.Ssar.Equipment.Utils;

namespace SSAR.Equipment.Model
{
	public class CosmeticGalleryArmorValidator : ICosmeticGalleryValidator
	{
		private readonly CosmeticGalleryArmorSubTabType _tabType;

		public CosmeticGalleryArmorValidator(CosmeticGalleryArmorSubTabType tabType)
		{
		}

		public bool IsValid(ICosmeticGalleryItemData info)
		{
			return false;
		}
	}
}
