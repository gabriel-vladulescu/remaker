using System.Collections.Generic;

namespace Ssar.Achievement.Metrics
{
	public class ObtainItemListener
	{
		private AchievementLogic achievementLogic;

		private static HashSet<ItemType> targetTypes;

		public ObtainItemListener(AchievementLogic achievementLogic)
		{
		}

		public void OnObtain(ItemInfo itemInfo)
		{
		}

		private string GetRarity(ItemInfo itemInfo)
		{
			return null;
		}

		private string GetItemType(ItemInfo itemInfo)
		{
			return null;
		}

		private int GetQuantity(ItemInfo itemInfo)
		{
			return 0;
		}
	}
}
