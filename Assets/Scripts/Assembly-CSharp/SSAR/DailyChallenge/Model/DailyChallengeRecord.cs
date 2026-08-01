using System;
using LitJson;

namespace Ssar.DailyChallenge.Model
{
	[Serializable]
	public class DailyChallengeRecord
	{
		[JsonInclude]
		private int round;

		[JsonInclude]
		private int enemiesDefeated;

		[JsonInclude]
		private int battleTime;

		[JsonIgnore]
		public int Round => 0;

		[JsonIgnore]
		public int EnemiesDefeated => 0;

		[JsonIgnore]
		public int BattleTime => 0;

		public DailyChallengeRecord()
		{
		}

		public DailyChallengeRecord(int round, int enemiesDefeated, int battleTime)
		{
		}

		public int CompareTo(DailyChallengeRecord record)
		{
			return 0;
		}
	}
}
