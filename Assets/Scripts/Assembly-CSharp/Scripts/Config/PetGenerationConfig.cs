using System.Collections.Generic;
using SSAR.Equipment.Enum;
using Scripts.Ssar.Pet;

namespace Scripts.Config
{
	public class PetGenerationConfig : IConfig
	{
		public Dictionary<string, MainStats> mainStatValues;

		public Dictionary<string, BonusStatQuantity> bonusStatsQuantities;

		public Dictionary<string, BonusStatValue> bonusStatsValues;

		public Dictionary<string, ShareStatInfo> shareStatsInfos;

		public Dictionary<string, ShareStatQuantity> shareStatsQuantities;

		public Dictionary<string, ShareStatValue> shareStatsValues;

		private Dictionary<string, List<MainStats>> dictMainStatForRarity;

		private Dictionary<Rarity, List<BonusStatValue>> dictBonusStatForRarity;

		private List<ShareStatType> listShareStatInfosAlwayHas;

		private Dictionary<Rarity, List<ShareStatValue>> dictShareStatForRarity;

		public void OnMapValue(string content)
		{
		}

		public List<MainStats> FindMainStatses(Rarity rarity, EquipmentTier tier)
		{
			return null;
		}

		public BonusStatQuantity FindBonusStatQuantity(Rarity rarity)
		{
			return null;
		}

		public List<BonusStatValue> FindBonusStatValues(Rarity rarity)
		{
			return null;
		}

		public ShareStatQuantity FindShareStatQuantity(Rarity rarity)
		{
			return null;
		}

		public List<ShareStatType> GetShareStatAlwayHas()
		{
			return null;
		}

		public List<ShareStatValue> FindShareStatValues(Rarity rarity)
		{
			return null;
		}

		public ShareStatInfo GetShareStatInfo(ShareStatType shareStatType)
		{
			return null;
		}

		private void MapDictMainStatForRarity()
		{
		}

		private void MapBonusStat()
		{
		}

		private void CacheListShareStatAlwayHas()
		{
		}

		private void MapDictShareStatForRarity()
		{
		}

		private int Comparer(ShareStatType a, ShareStatType b)
		{
			return 0;
		}

		private int Comparer(BonusStatValue a, BonusStatValue b)
		{
			return 0;
		}

		private int Comparer(ShareStatValue a, ShareStatValue b)
		{
			return 0;
		}

		private int Comparer(MainStats a, MainStats b)
		{
			return 0;
		}
	}
}
