using Scripts.Config;

namespace Ssar.Analytics.Metrics
{
	public class BaseData
	{
		private MainCharacterData mainCharacterData;

		public BaseData(MainCharacterData mainCharacterData)
		{
		}

		public string Version()
		{
			return null;
		}

		public string CharacterId()
		{
			return null;
		}

		public virtual string LevelString()
		{
			return null;
		}

		public virtual int Level()
		{
			return 0;
		}

		public int PlayingTime()
		{
			return 0;
		}

		public CharacterName CharacterName()
		{
			return default(CharacterName);
		}
	}
}
