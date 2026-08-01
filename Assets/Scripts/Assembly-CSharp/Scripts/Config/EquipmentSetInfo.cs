using SSAR.Equipment.Enum;

namespace Scripts.Config
{
	public class EquipmentSetInfo
	{
		public int id { get; set; }

		public int weaponVisualId { get; set; }

		public int helmetVisualId { get; set; }

		public int chestArmorVisualId { get; set; }

		public int wingVisualId { get; set; }

		public string localizeName { get; set; }

		public string rarity { get; set; }

		public ConfigWithCharacter icon { get; set; }

		public int GetVisualId(EquipmentType equipmentType)
		{
			return 0;
		}

		public Rarity Rarity()
		{
			return default(Rarity);
		}

		public string GetIcon(int groupId, int subId)
		{
			return null;
		}
	}
}
