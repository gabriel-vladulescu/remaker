using SSAR.Equipment.Enum;

namespace Scripts.Config
{
	public class GradeDropPercentage
	{
		private string rawValue;

		private EquipmentTier grade;

		private float percentage;

		public string RawValue => null;

		public EquipmentTier Grade => default(EquipmentTier);

		public float Percentage => 0f;

		public GradeDropPercentage(string rawValue)
		{
		}

		public GradeDropPercentage(EquipmentTier tier, float percentage)
		{
		}
	}
}
