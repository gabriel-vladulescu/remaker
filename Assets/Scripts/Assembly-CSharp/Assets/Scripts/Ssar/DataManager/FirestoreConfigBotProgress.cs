using Firebase.Firestore;

namespace Assets.Scripts.Ssar.DataManager
{
	[FirestoreData]
	public class FirestoreConfigBotProgress
	{
		[FirestoreProperty]
		public int bc { get; set; }

		[FirestoreProperty]
		public int bk { get; set; }

		[FirestoreProperty]
		public string dn { get; set; }

		[FirestoreProperty]
		public int gi { get; set; }

		[FirestoreProperty]
		public int l { get; set; }

		[FirestoreProperty]
		public int p { get; set; }

		[FirestoreProperty]
		public long tpt { get; set; }
	}
}
