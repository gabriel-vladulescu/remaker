using System;
using Firebase.Database;
using Firebase.Firestore;

namespace Ssar.Database
{
	public class FirebaseUserDataLoadingOperation
	{
		private const string PATH_TO_USER_DATA = "usersData";

		private FirebaseFirestore firebaseFirestore;

		private FirebaseDatabase firebaseDatabase;

		private bool isCompleted;

		public FirebaseUserDataLoadingOperation(FirebaseFirestore firebaseFirestore, FirebaseDatabase firebaseDatabase)
		{
		}

		public void LoadInt(string userId, string path, Action<bool, string, ErrorCode, int> callback)
		{
		}

		public void LoadIntDatabase(string userId, string path, Action<bool, string, ErrorCode, int> callback)
		{
		}

		public void Load(string userId, Action<bool, string, ErrorCode, UserData> callback)
		{
		}

		public void LoadDatabase(string userId, Action<bool, string, ErrorCode, UserData> callback)
		{
		}

		public static string Correct(string rawJsonValue)
		{
			return null;
		}

		public static void RemovePostfixFromDictionaryKeys(object obj)
		{
		}
	}
}
