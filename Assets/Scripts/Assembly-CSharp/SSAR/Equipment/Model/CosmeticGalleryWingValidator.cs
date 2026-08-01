using Assets.Scripts.Ssar.Equipment.Utils;

namespace SSAR.Equipment.Model
{
	public class CosmeticGalleryWingValidator : ICosmeticGalleryValidator
	{
		private readonly CosmeticGalleryWingSubTabType _tabType;

		public CosmeticGalleryWingValidator(CosmeticGalleryWingSubTabType tabType)
		{
		}

		public bool IsValid(ICosmeticGalleryItemData info)
		{
			return false;
		}
	}
}
