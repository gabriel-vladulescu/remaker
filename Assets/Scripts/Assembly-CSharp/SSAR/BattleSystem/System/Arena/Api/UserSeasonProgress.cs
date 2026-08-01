namespace SSAR.BattleSystem.System.Arena.Api
{
	public class UserSeasonProgress
	{
		public long l;

		public long ls;

		public long m;

		public long m_wr;

		public long s;

		public long s_wr;

		public string t;

		public long t_m_wr;

		public long t_wr;

		public long w;

		public long wr;

		public long ws;

		public UserSeasonProgress()
		{
		}

		public UserSeasonProgress(long l, long ls, long m, long s, string t, long w, long ws)
		{
		}

		public long ShowLoss()
		{
			return 0L;
		}

		public long ShowLossStreak()
		{
			return 0L;
		}

		public long ShowMmr()
		{
			return 0L;
		}

		public long ShowMmrWinRate()
		{
			return 0L;
		}

		public long ShowStars()
		{
			return 0L;
		}

		public long ShowStarsWinRate()
		{
			return 0L;
		}

		public TierName ShowTier()
		{
			return default(TierName);
		}

		public long ShowWin()
		{
			return 0L;
		}

		public float ShowWinRate()
		{
			return 0f;
		}

		public long ShowWinStreak()
		{
			return 0L;
		}
	}
}
