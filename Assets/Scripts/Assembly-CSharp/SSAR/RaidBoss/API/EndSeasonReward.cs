using System;
using Firebase.Firestore;

namespace Ssar.RaidBoss.API
{
	public class EndSeasonReward
	{
		public enum Status
		{
			Unknown = 0,
			AlreadyClaimed = 1,
			YetToBeClaimed = 2
		}

		private const string PATH = "seasonal/seasons/{0}/{1}/claimRewardStatus/data/{2}";

		private FirebaseFirestore firebaseFirestore;

		private HttpEndPoints endPoints;

		public EndSeasonReward(FirebaseFirestore firebaseFirestore, HttpEndPoints endPoints)
		{
		}

		public void ReadStatus(RaidDifficulty di, string uid, Action<bool, string, Status> callback)
		{
		}

		private void ReadStatus(int si, RaidDifficulty di, string uid, Action<bool, string, Status> callback)
		{
		}

		public void Claim(RaidDifficulty di, string uid, Action<bool, string> callback)
		{
		}

		private void Claim(int si, RaidDifficulty di, string uid, Action<bool, string> callback)
		{
		}
	}
}
