using System;
using System.Collections.Generic;
using CodeStage.AntiCheat.ObscuredTypes;
using LitJson;
using Ssar.RaidBoss.API;

namespace Ssar.RaidBoss.Model
{
	[Serializable]
	public class RaidData
	{
		[JsonInclude]
		private long totalLocalPlayedTime;

		[JsonInclude]
		private long localPlayedTime;

		[JsonInclude]
		public bool hasUnlock;

		[JsonInclude]
		public bool hasNotifyUnlock;

		[JsonInclude]
		private RaidDifficulty lastDifficulty;

		[JsonInclude]
		private Dictionary<string, long> seasonalPlayedTime;

		[JsonInclude]
		private Dictionary<string, BaseKeyData> entries;

		[JsonInclude]
		private BaseKeyData dailyEntry;

		[JsonInclude]
		private ObscuredInt lastTimePlay;

		private Dictionary<RaidDifficulty, RaidProgress> progressSeasons;

		private Dictionary<RaidDifficulty, RaidProgress> previousProgressSeasons;

		private RaidSeasonRankData previousRankData;

		private bool hasJoinedSeason;

		private bool hasLoadSeasonProgress;

		private bool hasLoadPreviousSeasonProgress;

		private bool loadedCurrentRankData;

		private bool loadedPreviousRankData;

		private bool sendCheckEligible;

		private List<RaidDifficulty> loadedRewardStatus;

		private Dictionary<RaidDifficulty, bool> claimedEndSeasonReward;

		private Dictionary<RaidDifficulty, int> globalKillCount;

		private List<RaidDifficulty> loadedGlobalRewardStatus;

		private Dictionary<RaidDifficulty, List<int>> globalRewardStatus;

		[JsonIgnore]
		public int DailyEntryRemaining => 0;

		[JsonIgnore]
		public int LastTimePlay => 0;

		public void AddLocalBattleTime(int seasonId, string difficulty, int battleTime)
		{
		}

		public void SetUnlock(bool unlock)
		{
		}

		public void SetNotifyUnlock(bool notified)
		{
		}

		public RaidDifficulty GetLastDifficulty()
		{
			return default(RaidDifficulty);
		}

		public void SetLastDifficulty(RaidDifficulty difficulty)
		{
		}

		public RaidProgress GetProgress(RaidDifficulty difficulty)
		{
			return null;
		}

		public RaidProgress GetPreviousProgress(RaidDifficulty difficulty)
		{
			return null;
		}

		public RaidSeasonRankData GetCurrentSeasonRankData()
		{
			return null;
		}

		public void LoadCurrentSeasonProgress(SeasonProgress progress)
		{
		}

		public void LoadPreviousSeasonProgress(SeasonProgress progress)
		{
		}

		public void JoinSeason()
		{
		}

		public bool HasJoinedSeason()
		{
			return false;
		}

		public bool IsLoadedSeasonProgress()
		{
			return false;
		}

		public void SetLoadedSeasonProgress(bool loaded)
		{
		}

		public void LoadCurrentRankData(RaidDifficulty difficulty, int rank)
		{
		}

		public RaidSeasonRankData GetPreviousSeasonRankData()
		{
			return null;
		}

		public RaidLeagueRankData GetPreviousRankData(RaidDifficulty difficulty)
		{
			return null;
		}

		public void SetPreviousSeasonRank(RaidSeasonRankData seasonRankData)
		{
		}

		public bool IsClaimedEndSeasonReward(RaidDifficulty difficulty)
		{
			return false;
		}

		public void SetClaimedEndSeasonReward(RaidDifficulty difficulty, bool hasClaim)
		{
		}

		public bool IsLoadedRewardStatus(RaidDifficulty difficulty)
		{
			return false;
		}

		public void SetLoadedRewardStatus(RaidDifficulty difficulty)
		{
		}

		public bool IsLoadedCurrentRank()
		{
			return false;
		}

		public void SetLoadedCurrentRank(bool value)
		{
		}

		public bool IsLoadedPreviousRank()
		{
			return false;
		}

		public void SetLoadedPreviousRank(bool value)
		{
		}

		public bool HasSendCheckEligible()
		{
			return false;
		}

		public void SendCheckEligible()
		{
		}

		public int GetGlobalKill(RaidDifficulty difficulty)
		{
			return 0;
		}

		public void SetGlobalKill(RaidDifficulty difficulty, int count)
		{
		}

		public void ResetDailyData()
		{
		}

		public List<int> GetGlobalRewardStatus(RaidDifficulty difficulty)
		{
			return null;
		}

		public void SetGlobalRewardStatus(RaidDifficulty difficulty, List<int> rewardIds)
		{
		}

		public bool IsGlobalRewardClaimed(RaidDifficulty difficulty, int rewardId)
		{
			return false;
		}

		public bool IsLoadedGlobalRewardStatus(RaidDifficulty difficulty)
		{
			return false;
		}

		private void SetLoadedGlobalRewardStatus(RaidDifficulty difficulty)
		{
		}

		public BaseKeyData GetEntryData(RaidDifficulty difficulty)
		{
			return null;
		}

		public void OnEnterRaid(RaidDifficulty difficulty)
		{
		}

		public void ValidateEntryData(RaidDifficulty difficulty)
		{
		}

		public void AddEntry(int key)
		{
		}

		private void AddEntry(RaidDifficulty difficulty, int key)
		{
		}

		private void ResetEntry()
		{
		}
	}
}
