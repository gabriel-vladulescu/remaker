using System.Collections.Generic;
using SSAR.Equipment.Enum;

namespace Scripts.Config
{
	public class EquipmentVisualConfig : IConfig
	{
		public Dictionary<string, EquipmentDefaultVisualInfo> defaults;

		public Dictionary<string, EquipmentVisualAvailableInfo> helmetAvailables;

		public Dictionary<string, EquipmentVisualAvailableInfo> weaponAvailables;

		public Dictionary<string, EquipmentVisualAvailableInfo> chestArmorAvailables;

		public Dictionary<string, EquipmentVisualAvailableInfo> pantAvailables;

		public Dictionary<string, EquipmentVisualAvailableInfo> amuletAvailables;

		public Dictionary<string, EquipmentVisualAvailableInfo> ringAvailables;

		public Dictionary<string, EquipmentVisualAvailableInfo> cosmeticHelmetAvailables;

		public Dictionary<string, EquipmentVisualAvailableInfo> cosmeticWeaponAvailables;

		public Dictionary<string, EquipmentVisualAvailableInfo> cosmeticChestArmorAvailables;

		public Dictionary<string, EquipmentVisualAvailableInfo> cosmeticWingAvailables;

		public Dictionary<string, EquipmentVisualAvailableInfo> ancientAvailables;

		public Dictionary<string, EquipmentSetInfo> sets;

		private Dictionary<string, List<EquipmentVisualAvailableInfo>> dictVisualIdAvailable;

		private Dictionary<string, EquipmentVisualAvailableInfo> dictEquipmentVisualInfos;

		private Dictionary<string, Rarity> dictEquipmentVisualInfosRarity;

		public void OnMapValue(string content)
		{
		}

		private void CacheEquipmentAvailable(Dictionary<string, EquipmentVisualAvailableInfo> dict, ref Dictionary<string, List<EquipmentVisualAvailableInfo>> cache, ref Dictionary<string, EquipmentVisualAvailableInfo> cache2)
		{
		}

		public List<int> GetListEquipmentVisualVailable(EquipmentType equipmentType, Rarity rarity, string visualCategory)
		{
			return null;
		}

		public List<int> GetListEquipmentVisualVailable(EquipmentType equipmentType, Rarity rarity)
		{
			return null;
		}

		public EquipmentVisualAvailableInfo GetEquipmentVisualInfo(EquipmentType equipmentType, int visualId)
		{
			return null;
		}

		public bool GetEquipmentVisualInfo(EquipmentType equipmentType, int visualId, ref EquipmentVisualAvailableInfo equipmentVisualAvailableInfo)
		{
			return false;
		}

		public EquipmentDefaultVisualInfo GetEquipmentDefaultVisualInfo(EquipmentType equipmentType)
		{
			return null;
		}

		public List<EquipmentVisualAvailableInfo> GetAllEquipmentVisualHasFolderParent(string folderParent)
		{
			return null;
		}

		public List<EquipmentVisualAvailableInfo> GetAllEquipmentVisualHasFolderParent(string folderParent, Dictionary<string, EquipmentVisualAvailableInfo> dict)
		{
			return null;
		}

		public bool GetMaxRarityOfItem(EquipmentType equipmentType, string visualCategory, ref Rarity maxRarity)
		{
			return false;
		}

		public bool GetEquipmentSetInfo(int setId, ref EquipmentSetInfo setInfo)
		{
			return false;
		}

		public bool IsInSet(EquipmentType equipmentType, int visualId, ref EquipmentSetInfo equipmentSetInfo)
		{
			return false;
		}

		private void CacheEquipmentVisualInfoMaxRarity(Dictionary<string, EquipmentVisualAvailableInfo> dict, ref Dictionary<string, Rarity> dictRarities)
		{
		}
	}
}
