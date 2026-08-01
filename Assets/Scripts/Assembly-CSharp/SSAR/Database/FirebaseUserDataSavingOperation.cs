using System;
using Firebase.Firestore;

namespace Ssar.Database
{
	public class FirebaseUserDataSavingOperation
	{
		private const string PATH_TO_USER_DATA = "usersData";

		private FirebaseFirestore defaultInstance;

		public FirebaseUserDataSavingOperation(FirebaseFirestore defaultInstance)
		{
		}

		public void Save(string userId, UserData userData, Action<bool, string> callback)
		{
		}

		public void SaveInt(string userId, string path, int value, Action<bool, string> callback)
		{
		}

		public static string Correct(string rawJsonValue)
		{
			return null;
		}
	}
}
