using System.Collections.Generic;
using Scripts.Config;

namespace Ssar.DailyQuest
{
	public class GeneratedQuestData
	{
		private IEnumerable<DailyQuestConfig.QuestItem> quests;

		private DailyQuestConfig.MasterQuestItem masterQuest;

		public IEnumerable<DailyQuestConfig.QuestItem> Quests => null;

		public DailyQuestConfig.MasterQuestItem MasterQuest => null;

		public GeneratedQuestData(IEnumerable<DailyQuestConfig.QuestItem> quests, DailyQuestConfig.MasterQuestItem masterQuest)
		{
		}
	}
}
