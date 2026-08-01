using Assets.Scripts.Ssar.Equipment.Utils;
using SSAR.Equipment.Model;

internal class CosmeticGallerySetValidator : ICosmeticGalleryValidator
{
	private readonly CosmeticGallerySetSubTabType _tabType;

	public CosmeticGallerySetValidator(CosmeticGallerySetSubTabType tabType)
	{
	}

	public bool IsValid(ICosmeticGalleryItemData info)
	{
		return false;
	}
}
