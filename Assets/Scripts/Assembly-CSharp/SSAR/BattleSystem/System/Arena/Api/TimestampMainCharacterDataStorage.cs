using Firebase.Firestore;
using SimpleJSON;

namespace SSAR.BattleSystem.System.Arena.Api
{
	public class TimestampMainCharacterDataStorage : MainCharacterDataStorage
	{
		public TimestampMainCharacterDataStorage(FirebaseFirestore firebaseFirestore)
			: base(null)
		{
		}

		protected override void ProcessJsonObj(JSONObject obj)
		{
		}
	}
}
