using SSAR.Equipment.Enum;

namespace Assets.Scripts.Ssar.Equipment
{
	public class DefaultTypeDropConfig : TypeDropConfig
	{
		private EquipmentType type;

		private float dropRate;

		public DefaultTypeDropConfig(EquipmentType type, float dropRate)
		{
		}

		public EquipmentType Type()
		{
			return default(EquipmentType);
		}

		public float DropRate()
		{
			return 0f;
		}
	}
}
