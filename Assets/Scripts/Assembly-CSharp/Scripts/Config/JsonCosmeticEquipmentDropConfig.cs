using System.Collections.Generic;
using SSAR.Equipment.Enum;

namespace Scripts.Config
{
	public class JsonCosmeticEquipmentDropConfig : JsonEquipmentDropConfig
	{
		public Dictionary<string, MainStats> wingsMainStats;

		public bool FindWingsMainStats(EquipmentTier grade, Rarity rarity, ref MainStats mainStats)
		{
			return false;
		}
	}
}
