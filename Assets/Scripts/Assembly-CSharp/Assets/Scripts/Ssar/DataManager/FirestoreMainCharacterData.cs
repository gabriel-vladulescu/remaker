using Firebase.Firestore;

namespace Assets.Scripts.Ssar.DataManager
{
	[FirestoreData]
	public class FirestoreMainCharacterData
	{
		[FirestoreProperty]
		public string data { get; set; }

		[FirestoreProperty]
		public long power { get; set; }

		[FirestoreProperty]
		public long migrateTime { get; set; }
	}
}
