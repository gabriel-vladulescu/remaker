using System;

namespace Scripts.Ssar.Pet
{
	[Serializable]
	public class PetShareStat
	{
		public float value;

		public ShareStatType type;

		public PetShareStat()
		{
		}

		public PetShareStat(ShareStatType type, float value)
		{
		}
	}
}
