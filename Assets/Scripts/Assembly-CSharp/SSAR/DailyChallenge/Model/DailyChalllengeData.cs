using System;
using System.Collections.Generic;
using CodeStage.AntiCheat.ObscuredTypes;
using LitJson;

namespace Ssar.DailyChallenge.Model
{
	[Serializable]
	public class DailyChalllengeData
	{
		[JsonInclude]
		private ObscuredInt entryCount;

		[JsonInclude]
		private ObscuredInt lastTimePlay;

		[JsonInclude]
		private Dictionary<string, DailyChallengeProgress> progresses;

		[JsonIgnore]
		public int EntryCount => 0;

		[JsonIgnore]
		public int LastTimePlay => 0;

		public DailyChallengeProgress GetProgress(ScenarioDifficulty difficulty)
		{
			return null;
		}

		public void AddLocalResult(ScenarioDifficulty difficulty, int round, int enemiesKilled, int battleTime)
		{
		}

		public void ResetEntry()
		{
		}

		public void OnEnterChallenge()
		{
		}

		private void UpdateHighestRecord(ScenarioDifficulty difficulty, DailyChallengeRecord record)
		{
		}
	}
}
