using System;
using Firebase.Database;
using Firebase.Firestore;

namespace Assets.Scripts.Ssar.DataManager
{
	public class FirebaseCloudDataControllerTest : FirebaseCloudDataController
	{
		public FirebaseCloudDataControllerTest(FirebaseFirestore firebaseFirestore, FirebaseDatabase firebaseDatabase)
			: base(null, null)
		{
		}

		public override void LoginGoogle(Action<string> success, Action<string> error)
		{
		}

		public override void GetFirebaseDataWithGoogle(Action<string, UserData> callBack, string googleToken)
		{
		}

		public override void GetFirebaseFacebookData(Action<string, UserData> callBack)
		{
		}

		private UserData Init()
		{
			return null;
		}
	}
}
