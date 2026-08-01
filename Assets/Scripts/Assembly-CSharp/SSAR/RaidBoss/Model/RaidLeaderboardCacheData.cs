using System.Collections.Generic;
using Assets.Scripts.Core.Scheduling;
using Scripts.Config;
using Ssar.RaidBoss.API;

namespace Ssar.RaidBoss.Model
{
	public class RaidLeaderboardCacheData : SimTimeObserver
	{
		private Dictionary<RaidDifficulty, List<RaidLeaderboardRowData>> leagueData;

		private Dictionary<RaidDifficulty, bool> hasGetData;

		private List<RaidDifficulty> hasRequested;

		private float timeRefreshLeaderBoard;

		private float intervalRefreshLeaderBoard;

		private float time;

		private float delay;

		private RaidDifficulty curDifficulty;

		public void UpdateCooldown(float cooldown)
		{
		}

		public bool HasGetLeaderboardDataFromServer(RaidDifficulty difficulty)
		{
			return false;
		}

		public void SetHasGetLeaderboardDataFromServer(RaidDifficulty difficulty, bool value)
		{
		}

		public bool HasRequestedLeaderboard(RaidDifficulty difficulty)
		{
			return false;
		}

		public void SetHasRequestedLeaderboard(RaidDifficulty difficulty)
		{
		}

		public void ResetLeaderboard()
		{
		}

		public List<RaidLeaderboardRowData> GetRowDatas(RaidDifficulty tabType)
		{
			return null;
		}

		public void UpdateLeaderboard(RaidDifficulty difficulty, List<UserInfo> userInfos)
		{
		}

		public int GetTimeToRefreshLeaderboard()
		{
			return 0;
		}

		public void OnSimTime(uint dt)
		{
		}

		internal void InitFakeData()
		{
		}

		private void InitFakeLeague(RaidDifficulty tabType, List<RandomDisplayFirstNameValue> nameList)
		{
		}
	}
}
