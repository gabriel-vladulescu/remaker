using System;
using System.Collections.Generic;
using SSAR.Equipment.Enum;

namespace Scripts.Ssar.Pet
{
	[Serializable]
	public class PetConfigId
	{
		public int visualId;

		public Rarity Rarity;

		public EquipmentTier Tier;

		public List<PetStat> mainStat;

		public List<PetShareStat> shareStats;

		public List<PetStat> bonusStats;
	}
}
