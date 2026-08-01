using System.Collections.Generic;
using LitJson;
using SSAR.Equipment.Model;

namespace Scripts.Config
{
	public class CosmeticGalleryConfig : IConfig
	{
		[JsonInclude]
		private Dictionary<string, CosmeticGallerySetInfo> sets;

		[JsonInclude]
		private Dictionary<string, CosmeticGalleryItemInfo> cosmeticWeapons;

		[JsonInclude]
		private Dictionary<string, CosmeticGalleryItemInfo> cosmeticHelmets;

		[JsonInclude]
		private Dictionary<string, CosmeticGalleryItemInfo> cosmeticChestArmors;

		[JsonInclude]
		private Dictionary<string, CosmeticGalleryItemInfo> cosmeticWings;

		private List<ICosmeticGalleryItemData> itemDatas;

		public void OnMapValue(string content)
		{
		}

		public List<ICosmeticGalleryItemData> GetItemInfos(ICosmeticGalleryValidator validator, ICosmeticGalleryComparer comparer)
		{
			return null;
		}

		public void SetupTable(ConfigManager configManager, int groupId, int subId)
		{
		}

		private void SetupTable(List<ICosmeticGalleryItemData> table, CosmeticGalleryItemType type, ConfigManager configManager, int groupId, int subId, Dictionary<string, CosmeticGalleryItemInfo> dict)
		{
		}
	}
}
