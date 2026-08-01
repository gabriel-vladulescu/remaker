using System;
using System.Collections.Generic;
using Ssar.Achievement.Model;

namespace Assets.Scripts.Ssar.DataManager
{
	[Serializable]
	public class AchievementData
	{
		public List<Progress> progresses;

		public Dictionary<string, AchievementItemData> achievementItemDatas;

		public void AddProgress(Progress newProgress)
		{
		}

		public IEnumerable<Progress> ShowProgresses()
		{
			return null;
		}

		public bool FindProgress(int id, ref Progress progress)
		{
			return false;
		}

		public AchievementItemData GetAchievementItemData(int achievementId)
		{
			return null;
		}
	}
}
