using System.Collections.Generic;
using SSAR.Equipment.Enum;

namespace Scripts.Config
{
	public class AwakenEquipmentConfig : IConfig
	{
		public Dictionary<string, AwakenEquipmentExpInfo> equipmentInfos;

		public Dictionary<string, AwakenEquipmentConstant> constant;

		public void OnMapValue(string content)
		{
		}

		public AwakenEquipmentExpInfo GetAwakenEquipmentExpInfo(Rarity rarity, EquipmentTier tier)
		{
			return null;
		}

		public AwakenEquipmentConstant GetAwakenEquipmentConstant()
		{
			return null;
		}
	}
}
