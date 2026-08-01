using System;
using System.Collections.Generic;
using Assets.Scripts.Ssar.Dungeon.View;
using LitJson;
using Scripts.Ssar.Arena;

namespace Scripts.Config
{
	public class ArenaConfig : IConfig
	{
		private int SEASON_ID_BUFFER;

		public Dictionary<string, ArenaConstantConfig> constant;

		public Dictionary<string, ArenaDailyRewardInfo> dailyRewards;

		public Dictionary<string, ArenaScalePowerByTierInfo> scalePowerByTier;

		public Dictionary<string, ArenaRuneInfo> runes;

		private List<ArenaDailyRewardInfo> arenaDailyRewardInfos;

		private Dictionary<int, List<SeasonalRankRewardValue>> dictSeasonalRankRwardValue;

		private Dictionary<int, List<SeasonalRankRewardId>> dictSeasonalRankRewardId;

		public Dictionary<string, PromotionRankRewardValue> PromotionArenaRankReward;

		public void OnMapValue(string content)
		{
		}

		public void CheckError()
		{
		}

		public List<SeasonalRankRewardValue> GetArenaLeagueRewards(ArenaTier arenaTier, int seasonId)
		{
			return null;
		}

		public List<PromotionRankRewardValue> GetArenaPromotionRewards(ArenaTier arenaTier)
		{
			return null;
		}

		private int Comparer(PromotionRankRewardValue a, PromotionRankRewardValue b)
		{
			return 0;
		}

		public PromotionRankRewardValue GetArenaPromotionReward(int rankID)
		{
			return null;
		}

		private List<SeasonalRankRewardValue> GetSeasonalRankRewardValues(int seasonId)
		{
			return null;
		}

		public List<ItemInfo> GetSeasonalRewardItemInfos(ArenaTier tier, int rank, int division, int seasonId)
		{
			return null;
		}

		public List<ItemInfo> GetItemInfos(SeasonalRankRewardValue seasonalRankRewardValue, int seasonId)
		{
			return null;
		}

		public List<ItemInfo> GetItemInfos(PromotionRankRewardValue promotionRankRewardValue)
		{
			return null;
		}

		private SeasonalRankRewardId GetSeasonalRankRewardValue(SeasonalRankRewardValue seasonalRankRewardValue, int seasonId)
		{
			return null;
		}

		private List<SeasonalRankRewardId> GetSeasonalRankRewardIds(int seasonId)
		{
			return null;
		}

		public List<ArenaDailyRewardInfo> GetArenaDailyRewardInfos()
		{
			return null;
		}

		public ArenaDailyRewardInfo GetArenaDailyRewardInfo(int participate)
		{
			return null;
		}

		public ArenaConstantConfig GetArenaConstantConfig()
		{
			return null;
		}

		public List<ArenaRuneInfo> GetArenaRuneInfos()
		{
			return null;
		}

		public ArenaScalePowerByTierInfo GetArenaScalePowerByTierInfo(ArenaTier arenaTier)
		{
			return null;
		}

		private void MapArenaDailyReward()
		{
		}

		private int Comparer(SeasonalRankRewardValue a, SeasonalRankRewardValue b)
		{
			return 0;
		}

		private int Comparer(SeasonalRankRewardId a, SeasonalRankRewardId b)
		{
			return 0;
		}

		private int Compare(ArenaDailyRewardInfo a, ArenaDailyRewardInfo b)
		{
			return 0;
		}

		private int Comparer(ItemInfo itemInfo, ItemInfo b)
		{
			return 0;
		}

		private void Setup(string content)
		{
		}

		private void ParseToValue<T>(string jsonkey, JsonData data, string sheetPrefixName, Action<int, List<T>> callBack) where T : class
		{
		}

		private T MapData<T>(JsonData data) where T : class
		{
			return null;
		}
	}
}
