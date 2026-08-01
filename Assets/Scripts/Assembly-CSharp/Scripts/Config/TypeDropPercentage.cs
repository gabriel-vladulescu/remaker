using SSAR.Equipment.Enum;

namespace Scripts.Config
{
	public class TypeDropPercentage
	{
		private string rawValue;

		private EquipmentType type;

		private int percentage;

		public string RawValue => null;

		public EquipmentType Type => default(EquipmentType);

		public int Percentage => 0;

		public TypeDropPercentage(string rawValue)
		{
		}

		public TypeDropPercentage(EquipmentType type, int percentage)
		{
		}
	}
}
