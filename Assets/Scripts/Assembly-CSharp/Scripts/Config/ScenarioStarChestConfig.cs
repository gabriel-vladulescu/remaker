using System.Collections.Generic;

namespace Scripts.Config
{
	public class ScenarioStarChestConfig : IConfig
	{
		public Dictionary<string, ScenarioStarChestRewardInfo> chests;

		private Dictionary<string, List<ScenarioStarChestRewardInfo>> cache;

		public void OnMapValue(string content)
		{
		}

		public List<ScenarioStarChestRewardInfo> GetChestRewardInfos(int mapId, ScenarioDifficulty difficulty)
		{
			return null;
		}

		private int Comparer(ScenarioStarChestRewardInfo a, ScenarioStarChestRewardInfo b)
		{
			return 0;
		}
	}
}
