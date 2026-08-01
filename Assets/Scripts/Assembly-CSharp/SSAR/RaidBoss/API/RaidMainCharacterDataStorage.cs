using Firebase.Firestore;
using SSAR.BattleSystem.System.Arena.Api;

namespace Ssar.RaidBoss.API
{
	public class RaidMainCharacterDataStorage : TimestampMainCharacterDataStorage
	{
		private const string path_to_main_character_data = "usersData/mainCharactersData/";

		protected const string path_to_bot = "bot_configs/mainCharactersData/";

		private static readonly string[] fieldNamesToRemove;

		public RaidMainCharacterDataStorage(FirebaseFirestore firebaseFirestore)
			: base(null)
		{
		}

		protected override string GetRefToCharacterData(CharacterId ci)
		{
			return null;
		}

		protected override string GetRefToBot(string characterId)
		{
			return null;
		}

		protected override string[] GetFieldNamesToRemove()
		{
			return null;
		}
	}
}
