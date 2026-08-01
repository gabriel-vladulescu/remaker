using Scripts.Config;
using Ssar.Analytics.Metrics.Values;

namespace Ssar.Analytics.Metrics.Feature
{
	public class FeatureData
	{
		private CharacterName characterName;

		private Level level;

		private NodeId highestNodeId;

		private int currentGold;

		private int currentCrystal;

		private float playingTime;

		public Level Level => null;

		public NodeId HighestNodeId => null;

		public int CurrentGold => 0;

		public int CurrentCrystal => 0;

		public float PlayingTime => 0f;

		public FeatureData(CharacterName characterName, Level level, NodeId highestNodeId, int currentGold, int currentCrystal, float playingTime)
		{
		}

		public CharacterName CharacterName()
		{
			return default(CharacterName);
		}
	}
}
