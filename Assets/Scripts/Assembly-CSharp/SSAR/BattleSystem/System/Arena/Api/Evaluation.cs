using System;
using Firebase.Firestore;

namespace SSAR.BattleSystem.System.Arena.Api
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
