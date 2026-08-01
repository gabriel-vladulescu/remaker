using System;
using System.Collections.Generic;
using Firebase.Database;

namespace Ssar.RaidBoss.API
{
	public class GlobalReward
	{
		private const string PATH = "raid/seasons/{0}/{1}/usersClaimGlobalRewardStatus/{2}";

		private FirebaseDatabase database;

		private HttpEndPoints endPoints;

		public GlobalReward(FirebaseDatabase database, HttpEndPoints endPoints)
		{
		}

		public void ReadStatus(RaidDifficulty difficulty, string uid, Action<bool, string, GlobalRewardStatus> callback)
		{
		}

		private void ReadStatus(int seasonId, RaidDifficulty difficulty, string uid, Action<bool, string, GlobalRewardStatus> callback)
		{
		}

		public void Claim(RaidDifficulty difficulty, string uid, int rewardId, Action<bool, string, GlobalRewardStatus> callback)
		{
		}

		private void Claim(int seasonId, RaidDifficulty difficulty, string uid, List<int> rewardIds, Action<bool, string, GlobalRewardStatus> callback)
		{
		}

		private string ConvertToRawData(List<int> rewardIds)
		{
			return null;
		}
	}
}
