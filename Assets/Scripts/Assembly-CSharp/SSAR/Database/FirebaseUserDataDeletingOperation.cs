using System;
using Firebase.Firestore;

namespace Ssar.Database
{
	public class FirebaseUserDataDeletingOperation
	{
		private const string PATH_TO_USER_DATA = "usersData";

		private FirebaseFirestore defaultInstance;

		public FirebaseUserDataDeletingOperation(FirebaseFirestore defaultInstance)
		{
		}

		public void Delete(string userId, Action<bool, string> callback)
		{
		}
	}
}
