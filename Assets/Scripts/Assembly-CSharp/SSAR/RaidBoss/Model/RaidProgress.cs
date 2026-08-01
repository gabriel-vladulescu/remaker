using Ssar.RaidBoss.API;

namespace Ssar.RaidBoss.Model
{
	public class RaidProgress
	{
		private int bossKilled;

		private int battleCount;

		private long totalPlayTime;

		private int rank;

		public int BossKilled
		{
			set
			{
			}
		}

		public int BattleCount
		{
			set
			{
			}
		}

		public long TotalPlayTime
		{
			set
			{
			}
		}

		public int Rank
		{
			set
			{
			}
		}

		public RaidProgress()
		{
		}

		public RaidProgress(Progress progress)
		{
		}

		public int GetBossKilled()
		{
			return 0;
		}

		public int GetBattleCount()
		{
			return 0;
		}

		public long GetTotalPlayTime()
		{
			return 0L;
		}

		public int GetRank()
		{
			return 0;
		}
	}
}
