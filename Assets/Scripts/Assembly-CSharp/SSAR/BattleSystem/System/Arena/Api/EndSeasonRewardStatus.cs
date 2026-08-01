using System;
using Firebase.Firestore;

namespace SSAR.BattleSystem.System.Arena.Api
{
	public class EndSeasonRewardStatus
	{
		public enum Status
		{
			Unknown = 0,
			AlreadyClaimed = 1,
			YetToBeClaimed = 2
		}

		private const string PATH_TO_MINE_FORMAT = "seasonal/seasons/{0}/claimRewardStatus/{1}";

		private FirebaseFirestore instance;

		public void Read(int seasonId, string userId, Action<bool, string, Status> callback)
		{
		}

		public void Claim(int seasonId, string userId, Action<bool, string> callback)
		{
		}
	}
}
