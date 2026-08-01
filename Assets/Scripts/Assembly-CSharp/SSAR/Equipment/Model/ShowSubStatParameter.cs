using SSAR.Equipment.Enum;

namespace SSAR.Equipment.Model
{
	public class ShowSubStatParameter
	{
		public StatType type;

		public float value;

		public float comparerDiff;

		public ShowSubStatParameter(StatType type, float value, float comparerDiff = 0f)
		{
		}
	}
}
