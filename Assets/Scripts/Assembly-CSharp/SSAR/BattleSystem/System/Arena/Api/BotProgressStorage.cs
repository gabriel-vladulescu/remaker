using System;
using Firebase.Firestore;

namespace SSAR.BattleSystem.System.Arena.Api
{
	public class BotProgressStorage
	{
		private FirebaseFirestore firebaseFirestore;

		public BotProgressStorage(FirebaseFirestore firebaseFirestore)
		{
		}

		public void Save(string botId, string json, Action<bool, string> callback)
		{
		}
	}
}
