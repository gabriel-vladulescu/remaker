namespace Ssar.RaidBoss.API
{
	public class GetSeasonDataResult
	{
		public int seasonId;

		public int previousSeasonId;

		public long currentSeasonStartTime;

		public long currentSeasonEndTime;

		public bool isCurrentSeasonUnderTransition;

		public int seasonCount;

		public bool isFirstSeason;

		public bool IsPreviousSeasonExisted()
		{
			return false;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
