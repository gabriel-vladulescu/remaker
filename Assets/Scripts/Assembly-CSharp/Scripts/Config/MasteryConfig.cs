using System.Collections.Generic;

namespace Scripts.Config
{
	public class MasteryConfig : IConfig
	{
		public Dictionary<string, MasteryInfo> masteryInfo;

		public Dictionary<string, MasteryLevelUpInfo> mastery1;

		public Dictionary<string, MasteryLevelUpInfo> mastery2;

		public Dictionary<string, MasteryLevelUpInfo> mastery3;

		public Dictionary<string, MasteryLevelUpInfo> mastery4;

		public Dictionary<string, MasteryLevelUpInfo> mastery5;

		public Dictionary<string, MasteryLevelUpInfo> mastery6;

		public Dictionary<string, MasteryLevelUpInfo> mastery7;

		public Dictionary<string, MasteryLevelUpInfo> mastery8;

		private List<MasteryInfo> m_masteryInfo;

		private Dictionary<int, List<MasteryLevelUpInfo>> dict;

		public void OnMapValue(string content)
		{
		}

		public List<MasteryInfo> GetMasteryInfos()
		{
			return null;
		}

		public List<MasteryLevelUpInfo> GetMasteryLevelUpInfos(int masteryId)
		{
			return null;
		}

		private int Comparer(MasteryInfo a, MasteryInfo b)
		{
			return 0;
		}

		private int ComparerLevelUp(MasteryLevelUpInfo a, MasteryLevelUpInfo b)
		{
			return 0;
		}

		private void MapListLevelUpInfo(int masteryId, Dictionary<string, MasteryLevelUpInfo> dict, ref Dictionary<int, List<MasteryLevelUpInfo>> ret)
		{
		}

		private void Valdiate()
		{
		}

		private void ValidateLevelUpInfo(Dictionary<string, MasteryLevelUpInfo> levelUpInfos)
		{
		}
	}
}
