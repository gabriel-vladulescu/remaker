using Firebase.Firestore;

namespace Assets.Scripts.Ssar.DataManager
{
	[FirestoreData]
	public class FirestoreUserData
	{
		[FirestoreProperty]
		public int lastTimeLoaded { get; set; }

		[FirestoreProperty]
		public int todayLoadAvailable { get; set; }

		[FirestoreProperty]
		public string data { get; set; }

		[FirestoreProperty]
		public long migrateTime { get; set; }
	}
}
