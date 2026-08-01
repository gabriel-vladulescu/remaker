using Scripts.Config;
using Ssar.Analytics.Metrics.Values;

namespace Ssar.Analytics.Metrics.Tutorial
{
	public class CombatTutorialData
	{
		private CharacterName characterName;

		private NodeId highestNodeId;

		private int currentGold;

		private int currentCrystal;

		private float playingTime;

		public CharacterName CharacterName => default(CharacterName);

		public NodeId HighestNodeId => null;

		public int CurrentGold => 0;

		public int CurrentCrystal => 0;

		public float PlayingTime => 0f;

		public CombatTutorialData(CharacterName characterName, NodeId highestNodeId, int currentGold, int currentCrystal, float playingTime)
		{
		}
	}
}
