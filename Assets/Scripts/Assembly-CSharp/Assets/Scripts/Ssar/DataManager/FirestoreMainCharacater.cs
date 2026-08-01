using Firebase.Firestore;

namespace Assets.Scripts.Ssar.DataManager
{
	[FirestoreData]
	public class FirestoreMainCharacater
	{
		[FirestoreProperty]
		public string data { get; set; }
	}
}
