using Firebase.Firestore;

namespace Assets.Scripts.Ssar.DataManager
{
	[FirestoreData]
	public class FirestoreStatus
	{
		[FirestoreProperty]
		public bool value { get; set; }
	}
}
