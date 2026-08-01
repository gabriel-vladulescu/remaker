using Firebase.Firestore;

namespace Assets.Scripts.Ssar.DataManager
{
	[FirestoreData]
	public class FirestoreUserCountForBossKill
	{
		[FirestoreProperty]
		public int[] usersCountFOrBossKill { get; set; }
	}
}
