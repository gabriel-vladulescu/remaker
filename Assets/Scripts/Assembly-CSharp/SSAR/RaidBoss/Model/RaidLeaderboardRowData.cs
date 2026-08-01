using Ssar.RaidBoss.API;

namespace Ssar.RaidBoss.Model
{
	public class RaidLeaderboardRowData
	{
		public string userId;

		public int battleCount;

		public int bossKill;

		public long totalPlayTime;

		public string displayName;

		public int level;

		public long power;

		public int groupId;

		public int rank;

		public string countryCode;

		public RaidLeaderboardRowData()
		{
		}

		public RaidLeaderboardRowData(UserInfo userInfo)
		{
		}

		private void ValidateData()
		{
		}
	}
}
