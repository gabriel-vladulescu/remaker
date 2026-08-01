using Firebase.Firestore;

namespace Assets.Scripts.Ssar.DataManager
{
	[FirestoreData]
	public class FirestoreBk
	{
		[FirestoreProperty]
		public int bk { get; set; }
	}
}
