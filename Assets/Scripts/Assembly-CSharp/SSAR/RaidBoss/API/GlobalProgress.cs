using System;
using Firebase.Firestore;

namespace Ssar.RaidBoss.API
{
	public class GlobalProgress
	{
		private const string PATH = "seasonal/seasons/{0}/{1}/globalProgress";

		private FirebaseFirestore firebaseFirestore;

		private HttpEndPoints endPoints;

		public GlobalProgress(FirebaseFirestore firebaseFirestore, HttpEndPoints endPoints)
		{
		}

		public void ReadCurrentSeasonKill(RaidDifficulty difficulty, Action<bool, string, int> callback)
		{
		}

		public void ReadPreviousSeasonKill(RaidDifficulty difficulty, Action<bool, string, int> callback)
		{
		}

		private void ReadKill(int seasonId, RaidDifficulty difficulty, Action<bool, string, int> callback)
		{
		}
	}
}
