using Firebase.Firestore;

namespace Assets.Scripts.Ssar.DataManager
{
	[FirestoreData]
	public class FirestoreUserProgress
	{
		[FirestoreProperty]
		public int l { get; set; }

		[FirestoreProperty]
		public int ls { get; set; }

		[FirestoreProperty]
		public int m { get; set; }

		[FirestoreProperty]
		public int m_wr { get; set; }

		[FirestoreProperty]
		public int s { get; set; }

		[FirestoreProperty]
		public int s_wr { get; set; }

		[FirestoreProperty]
		public string t { get; set; }

		[FirestoreProperty]
		public int t_m_wr { get; set; }

		[FirestoreProperty]
		public int t_wr { get; set; }

		[FirestoreProperty]
		public int w { get; set; }

		[FirestoreProperty]
		public int wr { get; set; }

		[FirestoreProperty]
		public int ws { get; set; }
	}
}
