using Scripts.Config;

namespace Ssar.Analytics.Metrics.Social
{
	public class DefaultSocialData : SocialData
	{
		private BaseData baseData;

		private MainCharacterData mainCharacterData;

		private DungeonConfig dungeonConfig;

		public DefaultSocialData(BaseData baseData, MainCharacterData mainCharacterData, DungeonConfig dungeonConfig)
		{
		}

		public CharacterName CharacterName()
		{
			return default(CharacterName);
		}

		public string LevelString()
		{
			return null;
		}

		public int Level()
		{
			return 0;
		}

		public string HighestNodeId()
		{
			return null;
		}

		public int CurrentGold()
		{
			return 0;
		}

		public int CurrentCrystal()
		{
			return 0;
		}

		public float PlayingTime()
		{
			return 0f;
		}
	}
}
