using SSAR.Equipment.Enum;

namespace Assets.Scripts.Model
{
	public interface IItem
	{
		int enhanceLevel { get; set; }

		int awakenExp { get; set; }

		int collectID { get; set; }

		EnhanceItemType EnhanceItemType { get; set; }

		Rarity Rarity();

		EquipmentTier Tier();
	}
}
