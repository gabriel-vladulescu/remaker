using System;
using Firebase.Firestore;

namespace Ssar.RaidBoss.API
{
	public class RaidBotProgressStorage
	{
		private FirebaseFirestore firebaseFirestore;

		public RaidBotProgressStorage(FirebaseFirestore firebaseFirestore)
		{
		}

		public void Save(RaidDifficulty di, string botId, string json, string charId, Action<bool, string> callback)
		{
		}
	}
}
