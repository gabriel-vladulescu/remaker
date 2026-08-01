using System.Collections.Generic;
using SSAR.Equipment.Enum;

namespace Scripts.Config
{
	public class JsonRandomEquipmentConfig : IConfig
	{
		public Dictionary<string, RandomEquipment> equipments;

		public void OnMapValue(string content)
		{
		}

		private void ValidateEveryRatesEqual100()
		{
		}

		public RandomEquipment FindRandomEquipment(int id)
		{
			return null;
		}

		public bool FindRandomEquipmentId(EquipmentType equipmentType, Rarity rarity, string visualCategory, ref int id)
		{
			return false;
		}
	}
}
