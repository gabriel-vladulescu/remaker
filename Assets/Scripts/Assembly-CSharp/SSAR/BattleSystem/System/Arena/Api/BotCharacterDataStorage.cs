using Firebase.Firestore;

namespace SSAR.BattleSystem.System.Arena.Api
{
	public class BotCharacterDataStorage : MainCharacterDataStorage
	{
		public class BotId : CharacterId
		{
			private readonly string characterName;

			private readonly int count;

			public BotId(string characterName, int count)
				: base(null, null, 0)
			{
			}

			public override string Obtain()
			{
				return null;
			}
		}

		private readonly BotId botId;

		public BotCharacterDataStorage(BotId botId, FirebaseFirestore firebaseFirestore)
			: base(null)
		{
		}

		protected override string GetRefToCharacterData(CharacterId ci)
		{
			return null;
		}

		protected override CharacterId GetCharacterId(MainCharacterData mcd)
		{
			return null;
		}
	}
}
