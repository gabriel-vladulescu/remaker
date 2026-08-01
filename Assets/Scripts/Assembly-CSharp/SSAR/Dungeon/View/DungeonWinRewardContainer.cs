using System.Collections.Generic;
using SSAR.Dungeon.Model;
using UnityEngine;

namespace SSAR.Dungeon.View
{
	public class DungeonWinRewardContainer : MonoBehaviour
	{
		public UITable table;

		public int maxDisplay;

		private List<DungeonRewardView> rewardItemViews;

		private void Awake()
		{
		}

		public void Hide()
		{
		}

		public void Show(DungeonWinParameter parameter, bool bonusItem)
		{
		}

		public void ShowRewardOnly(List<ItemInfo> rewards, bool bonusItem)
		{
		}
	}
}
