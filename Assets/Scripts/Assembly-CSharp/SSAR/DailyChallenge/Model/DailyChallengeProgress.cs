using System;
using LitJson;

namespace Ssar.DailyChallenge.Model
{
	[Serializable]
	public class DailyChallengeProgress
	{
		[JsonInclude]
		private int battleCount;

		[JsonInclude]
		private int roundPassed;

		[JsonInclude]
		private long totalPlayTime;

		[JsonInclude]
		private DailyChallengeRecord highestRecord;

		[JsonIgnore]
		public int BattleCount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[JsonIgnore]
		public int RoundPassed
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[JsonIgnore]
		public long TotalPlayTime
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		[JsonIgnore]
		public DailyChallengeRecord HighestRecord
		{
			get
			{
				return null;
			}
			set
			{
			}
		}
	}
}
