using System.Collections.Generic;

namespace Ssar.RaidBoss.Model
{
	public class RaidDataManager
	{
		private Dictionary<string, RaidUserInfo> userInfos;

		private List<RaidUserInfo> companions;

		private RaidStartBattleInfo startBattleInfo;

		public RaidUserInfo GetCharacterData(string userId)
		{
			return null;
		}

		public void CacheCharacterData(string userId, RaidUserInfo userInfo)
		{
		}

		public List<RaidUserInfo> GetCompanions()
		{
			return null;
		}

		public void CacheCompanions(List<RaidUserInfo> companions)
		{
		}

		public void ResetCompanions()
		{
		}

		public void SetStartBattleInfo(bool isOnline)
		{
		}

		public bool IsOnlineMode()
		{
			return false;
		}
	}
}
