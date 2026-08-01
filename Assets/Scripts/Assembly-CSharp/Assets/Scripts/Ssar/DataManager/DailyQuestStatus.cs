using System;

namespace Assets.Scripts.Ssar.DataManager
{
	[Serializable]
	public class DailyQuestStatus
	{
		public int questId;

		public bool isClaimed;

		public bool isUnlock;
	}
}
