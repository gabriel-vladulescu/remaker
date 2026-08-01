using Assets.Scripts.Ssar.Equipment.Utils;
using SSAR.Equipment.Model;

internal class CosmeticGalleryRecommendValidator : ICosmeticGalleryValidator
{
	private readonly CosmeticGalleryRecommendTabType _tabType;

	public CosmeticGalleryRecommendValidator(CosmeticGalleryRecommendTabType tabType)
	{
	}

	public bool IsValid(ICosmeticGalleryItemData info)
	{
		return false;
	}
}
