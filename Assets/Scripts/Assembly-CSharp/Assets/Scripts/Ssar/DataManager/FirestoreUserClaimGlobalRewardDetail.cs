using Firebase.Firestore;

namespace Assets.Scripts.Ssar.DataManager
{
	[FirestoreData]
	public class FirestoreUserClaimGlobalRewardDetail
	{
		[FirestoreProperty]
		public string data { get; set; }
	}
}
