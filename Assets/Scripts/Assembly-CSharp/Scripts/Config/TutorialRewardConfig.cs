using System.Collections.Generic;

namespace Scripts.Config
{
	public class TutorialRewardConfig : IConfig
	{
		public Dictionary<string, TutorialStepInfo> group;

		public Dictionary<string, TutorialStepPreparedata> prepareItems;

		public Dictionary<string, TutorialStepRewardInfo> rewardItems;

		private Dictionary<int, List<ItemInfo>> prepare;

		private Dictionary<int, List<ItemInfo>> reward;

		public void OnMapValue(string content)
		{
		}

		public List<ItemInfo> GetPrepareItemInfos(int tutorialGroupid)
		{
			return null;
		}

		public List<ItemInfo> GetRewardInfo(int tutorialGroupId)
		{
			return null;
		}
	}
}
