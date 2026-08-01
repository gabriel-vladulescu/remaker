using UnityEngine;

namespace Ssar.DailyChallenge.Config
{
	public class CharacterPresets : MonoBehaviour
	{
		[SerializeField]
		private TextAsset character1Source;

		[SerializeField]
		private TextAsset character2Source;

		[SerializeField]
		private TextAsset character3Source;

		[SerializeField]
		private TextAsset character4Source;

		public MainCharacterData GetCharacterData(int groupId)
		{
			return null;
		}

		private MainCharacterData Convert(TextAsset source)
		{
			return null;
		}
	}
}
