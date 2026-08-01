using System.Collections.Generic;
using CodeStage.AntiCheat.ObscuredTypes;
using LitJson;
using SSAR.BattleSystem.System.Arena.Api;

namespace Scripts.Ssar.Arena
{
	public class DuelArenaData
	{
		[JsonInclude]
		private DuelArenaTodayData todayData;

		private bool hasEndSeasonReward;

		private bool hasClaimEndSeasonReward;

		private UserSeasonProgress newSeasonProgress;

		private bool hasLoadSeasonProgress;

		private int mmrRank;

		private bool sendCheckEligible;

		[JsonInclude]
		private RankData previousRankdata;

		[JsonInclude]
		private int playTimeOfCurrentSeason;

		[JsonInclude]
		private int playTimeOfTotal;

		[JsonInclude]
		private int highestRankID;

		[JsonInclude]
		private int currentRankID;

		[JsonInclude]
		private bool canClaimedPromotionReward;

		[JsonInclude]
		private Dictionary<string, bool> PromotionRewardDataDict;

		[JsonInclude]
		private BaseKeyData entryData;

		[JsonInclude]
		private ObscuredInt lastTimePlay;

		[JsonInclude]
		private RankData highestRankData;

		[JsonInclude]
		private int totalBattle;

		[JsonIgnore]
		public int EntryRemaining => 0;

		[JsonIgnore]
		public int MaxEntry => 0;

		[JsonIgnore]
		public int TimeToRecoveryEntry => 0;

		[JsonIgnore]
		public int LastTimePlay => 0;

		[JsonIgnore]
		public int TotalBattle => 0;

		public void SetEntryConfig(int max, int intervalInSeconds)
		{
		}

		public void OnEnterTower()
		{
		}

		public void OnEnterRaid()
		{
		}

		public void OnEnterArena()
		{
		}

		public void AddKey(int key)
		{
		}

		public void AddToPromotionRewardDataDict(string key, bool value)
		{
		}

		public void SetValueToKeyToPromotionRewardDataDict(string key, bool value)
		{
		}

		public Dictionary<string, bool> GetPromotionRewardDataDict()
		{
			return null;
		}

		public bool GetValueFromPromotionRewardDataDict(int key)
		{
			return false;
		}

		public int GetHighestRankID()
		{
			return 0;
		}

		public void SetHighestRankID(int rankID)
		{
		}

		public int GetCurrentRankID()
		{
			return 0;
		}

		public void SetCurrentRankID(int rankID)
		{
		}

		public bool GetCanClaimPromotionReward()
		{
			return false;
		}

		public void SetCanClaimPromotionReward(bool b)
		{
		}

		public RankData GetHighestRankData()
		{
			return null;
		}

		public bool TrySetHighestRankData(RankData rankData)
		{
			return false;
		}

		public DuelArenaTodayData GetTodayData()
		{
			return null;
		}

		public void ThroughNewDay()
		{
		}

		public void UpdateUserSeasonProgress(UserSeasonProgress userSeasonProgress, int mmrRank)
		{
		}

		public UserSeasonProgress GetUserSeasonProgress()
		{
			return null;
		}

		public void LoadSeasonProgress(UserSeasonProgress userSeasonProgress, int mmrRank)
		{
		}

		public bool HasLoadSeasonProgress()
		{
			return false;
		}

		public RankData PreviousRanKdata()
		{
			return null;
		}

		public bool HasClaimEndSeasonReward()
		{
			return false;
		}

		public void SetHasEndSeasonReward(RankData rankData)
		{
		}

		public void SetHasClaimEndSeasonReward(bool hasClaim)
		{
		}

		public void SetMMRRank(int mmrRank)
		{
		}

		public int GetMMrRank()
		{
			return 0;
		}

		public void ResetPlayTimeOfCurrentSeason()
		{
		}

		public int ReadPlayTimeOfCurrentSeason()
		{
			return 0;
		}

		public void AddToPlayTime(int seconds)
		{
		}

		public int ReadPlayTimeOfTotal()
		{
			return 0;
		}

		public bool HasSendCheckEligible()
		{
			return false;
		}

		public void SendCheckEligible()
		{
		}
	}
}
