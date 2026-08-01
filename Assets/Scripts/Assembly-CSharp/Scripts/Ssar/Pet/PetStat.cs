using System;
using SSAR.Equipment.Enum;

namespace Scripts.Ssar.Pet
{
	[Serializable]
	public class PetStat
	{
		public float value;

		public StatType type;

		public PetStat()
		{
		}

		public PetStat(StatType type, float value)
		{
		}
	}
}
