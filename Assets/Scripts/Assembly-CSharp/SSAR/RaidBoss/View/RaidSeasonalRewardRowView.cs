using System.Collections.Generic;
using Scripts.Ssar.Arena;
using Ssar.RaidBoss.Model;
using UnityEngine;

namespace Ssar.RaidBoss.View
{
	public class RaidSeasonalRewardRowView : MonoBehaviour
	{
		public UILabel lb_rank;

		public UITable table;

		private RewardListItemView[] rewardViews;

		private RaidSeasonalRewardRowData rowData;

		private int seasonCode;

		private void Awake()
		{
		}

		private void ShowReward(List<ItemInfo> itemInfos)
		{
		}

		private void UpdateTextColor(int index)
		{
		}

		public void Show(int index, RaidSeasonalRewardRowData rowData, int seasonCode)
		{
		}

		public void Hide()
		{
		}
	}
}
