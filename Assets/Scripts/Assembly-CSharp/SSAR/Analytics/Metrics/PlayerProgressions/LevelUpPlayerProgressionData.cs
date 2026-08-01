using Scripts.Config;

namespace Ssar.Analytics.Metrics.PlayerProgressions
{
	public class LevelUpPlayerProgressionData : PlayerProgressionData
	{
		private int level;

		private PlayerProgressionData playerProgressionData;

		public LevelUpPlayerProgressionData(int level, PlayerProgressionData playerProgressionData)
		{
		}

		public string Version()
		{
			return null;
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

		public string NodeId()
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

		public float RealMoneySpent()
		{
			return 0f;
		}

		public string NodeValue()
		{
			return null;
		}

		public string HighestNodeValue()
		{
			return null;
		}

		public double Blood()
		{
			return 0.0;
		}
	}
}
