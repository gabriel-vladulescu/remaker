using Assets.Scripts.Ssar.Equipment.Utils;

namespace SSAR.Equipment.Model
{
	public class CosmeticGalleryWeaponValidator : ICosmeticGalleryValidator
	{
		private readonly CosmeticGalleryWeaponSubTabType _tabType;

		public CosmeticGalleryWeaponValidator(CosmeticGalleryWeaponSubTabType tabType)
		{
		}

		public bool IsValid(ICosmeticGalleryItemData info)
		{
			return false;
		}
	}
}
