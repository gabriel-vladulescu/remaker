using System;
using SSAR.Equipment.Enum;

namespace SSAR.Equipment.Model
{
	[Serializable]
	public class EquipmentStat
	{
		public float value;

		public StatType type;

		public float cacheValueBeforeRebalance144;

		public EquipmentStat()
		{
		}

		public EquipmentStat(StatType type, float value)
		{
		}
	}
}
