using Scripts.Config;

namespace Ssar.Analytics.Metrics.Feature
{
	public class FeatureCustomEventData
	{
		protected MainCharacterData mainCharacterData;

		protected DungeonConfig dungeonConfig;

		public NewCustomEventData GetNewCustomEventData()
		{
			return null;
		}

		public CharacterName CharacterName()
		{
			return default(CharacterName);
		}

		public virtual int Level()
		{
			return 0;
		}

		public int PlayingTime()
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
	}
}
