using System;
using System.Collections.Generic;
using Firebase.Firestore;
using SimpleJSON;

namespace SSAR.BattleSystem.System.Arena.Api
{
	public class MainCharacterDataStorage
	{
		private static string path_to_main_character_data;

		public static string exceptionMessage;

		private static string[] fieldNamesToRemove;

		private FirebaseFirestore firebaseFirestore;

		public MainCharacterDataStorage(FirebaseFirestore firebaseFirestore)
		{
		}

		public void Save(MainCharacterData mcd, string collection, Action<bool, string> callback)
		{
		}

		public void Read(string characterId, string collection, Action<bool, string, MainCharacterData> callback)
		{
		}

		protected virtual CharacterId GetCharacterId(MainCharacterData mcd)
		{
			return null;
		}

		protected virtual string GetRefToCharacterData(CharacterId ci)
		{
			return null;
		}

		protected virtual string GetRefToBot(string characterId)
		{
			return null;
		}

		protected virtual string[] GetFieldNamesToRemove()
		{
			return null;
		}

		protected virtual void ProcessJsonObj(JSONObject obj)
		{
		}

		private void RemoveUnusedData(JSONObject obj, List<string> fieldNameToRemove)
		{
		}
	}
}
