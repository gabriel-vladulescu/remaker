using Ssar.RaidBoss.API;

namespace Ssar.RaidBoss.Model
{
	public class RaidCurrentSeasonDataManager
	{
		private long currentTimeInMilisecond;

		private long timeStartCheck;

		private long seasonEndTime;

		private long seasonStartTime;

		private bool hasLoadSeasonInfo;

		private int seasonalCode;

		public int seasonId;

		private int previousSeasonalId;

		public bool isCurrentSeasonUnderTransition;

		public bool isFirstSeason;

		private bool hasLoadServerTime;

		private bool anotherSeasonStart;

		public void SetServerTime(long currentTimeInMilisecond)
		{
		}

		public void SetSeasonInfo(GetSeasonDataResult seasonData)
		{
		}

		public void SetAnotherSeasonStart(bool anotherSeasonStart)
		{
		}

		public int GetSeasonalCode()
		{
			return 0;
		}

		public int GetSeasonId()
		{
			return 0;
		}

		public bool HasLoadSeasonInfo()
		{
			return false;
		}

		public long GetServerStartTime()
		{
			return 0L;
		}

		public long GetCurrentTime()
		{
			return 0L;
		}

		public bool HasLoadServerTime()
		{
			return false;
		}

		public long GetSeasonEndTime()
		{
			return 0L;
		}

		public bool IsUnderProcess()
		{
			return false;
		}

		public bool IsOutdatedSeason()
		{
			return false;
		}

		public bool IsAnotherSeasonStart()
		{
			return false;
		}
	}
}
