using SSAR.Equipment.Enum;

namespace Assets.Scripts.Ssar.Equipment
{
	public interface StatsConfig
	{
		StatType Type();

		float[] Range();
	}
}
