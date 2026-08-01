using SSAR.Equipment.Enum;

namespace Assets.Scripts.Ssar.Equipment
{
	public class DefaultGradeDropConfig : GradeDropConfig
	{
		private EquipmentTier grade;

		private float dropRate;

		public DefaultGradeDropConfig(EquipmentTier grade, float dropRate)
		{
		}

		public EquipmentTier Grade()
		{
			return default(EquipmentTier);
		}

		public float DropRate()
		{
			return 0f;
		}
	}
}
