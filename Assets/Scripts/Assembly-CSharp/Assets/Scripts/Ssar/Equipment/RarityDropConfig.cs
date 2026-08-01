using SSAR.Equipment.Enum;

namespace Assets.Scripts.Ssar.Equipment
{
	public interface RarityDropConfig
	{
		Rarity Rarity();

		float DropRate();
	}
}
