using System.Collections.Generic;
using SSAR.Equipment.Enum;

namespace Scripts.Config
{
	public class EquipmentVisualAvailableInfo
	{
		public static readonly string CHARACTER_AVAILABLE_ALL;

		public static readonly string EQUIPMENT_VISUAL_CATEGORY;

		public List<string> visualCategory;

		public string equipmentType { get; set; }

		public int visualId { get; set; }

		public string minRarity { get; set; }

		public string maxRarity { get; set; }

		public ConfigWithCharacter localizeName { get; set; }

		public ConfigWithCharacter icon { get; set; }

		public ConfigWithCharacter visualFolderParent { get; set; }

		public string visualCommonPath { get; set; }

		public string visualUnCommonPath { get; set; }

		public string visualMagicPath { get; set; }

		public string visualRarePath { get; set; }

		public string visualLegendaryPath { get; set; }

		public string visualUltimatePath { get; set; }

		public EquipmentType GetEquipmentType()
		{
			return default(EquipmentType);
		}

		public Rarity MinRarity()
		{
			return default(Rarity);
		}

		public Rarity MaxRarity()
		{
			return default(Rarity);
		}

		public bool IsContainVisualCategory(string category)
		{
			return false;
		}

		public string GetVisualPath(int groupId, int subId, Rarity rarity)
		{
			return null;
		}

		public string GetIcon(int groupId, int subId)
		{
			return null;
		}

		public string GetLocalizeName(int groupId, int subId)
		{
			return null;
		}

		public string GetPrefabName(Rarity rarity)
		{
			return null;
		}
	}
}
