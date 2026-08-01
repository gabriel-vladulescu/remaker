using System.Collections.Generic;

namespace Scripts.Config
{
	public class LevelUpRewardConfig : IConfig
	{
		public Dictionary<string, LevelUpReward> rewards;

		public void OnMapValue(string content)
		{
		}

		public LevelUpReward GetLevelUpReward(int level)
		{
			return null;
		}
	}
}
