using System.Collections.Generic;
using LitJson;

namespace Scripts.Ssar.Arena
{
	public class RecordCacheData
	{
		[JsonInclude]
		private Dictionary<string, List<ArenaLeaderboardRowData>> recordDict;

		[JsonInclude]
		private Dictionary<string, LastArenaOpponentInfo> lastOpponentInfos;

		public void AddRecord(string userId, ArenaLeaderboardRowData data)
		{
		}

		public void ResetRecord(string userId)
		{
		}

		public LastArenaOpponentInfo GetLastArenaOpponentInfo(string userId)
		{
			return null;
		}

		public void AddOpponentInfo(string userId, LastArenaOpponentInfo lastArenaOpponentInfo)
		{
		}

		public void RemoveOpponentInfo(string userId)
		{
		}

		public List<ArenaLeaderboardRowData> GetRecord(string userId)
		{
			return null;
		}
	}
}
