using System;
using Firebase.Firestore;
using SSAR.BattleSystem.System.Arena.Api;

namespace Ssar.RaidBoss.API
{
	public class Evaluation
	{
		private readonly FirebaseFirestore firebaseFirestore;

		private readonly CharacterId charId;

		private readonly bool eligible;

		public Evaluation(FirebaseFirestore firebaseFirestore, CharacterId charId, bool eligible)
		{
		}

		public void Act(Action<bool> callback)
		{
		}
	}
}
