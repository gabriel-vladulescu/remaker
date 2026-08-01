using System;

namespace Assets.Scripts.Ssar.AnniversaryEvent
{
	[Serializable]
	public class QuestInfo
	{
		public int id;

		public string questType;

		public int require;

		public int crystal;

		public ItemInfo GetReward()
		{
			return null;
		}

		public QuestType GetQuestType()
		{
			return default(QuestType);
		}
	}
}
