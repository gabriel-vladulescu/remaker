using System.Collections.Generic;
using Scripts.Ssar.Arena;
using Ssar.RaidBoss.Model;
using UnityEngine;

namespace Ssar.RaidBoss.View
{
	public class RaidGlobalRewardRowView : MonoBehaviour
	{
		public UILabel lb_rank;

		public UITable table;

		public GameObject btnClaim;

		public GameObject objClaimed;

		private RewardListItemView[] rewardViews;

		private RaidGlobalRewardRowData rowData;

		private RaidDifficulty difficulty;

		private int rewardId;

		private void Awake()
		{
		}

		private void ClickClaim(GameObject go)
		{
		}

		private void TestRewards(GameObject go)
		{
		}

		internal void Show(int index, RaidGlobalRewardRowData rowData)
		{
		}

		internal void Hide()
		{
		}

		private void ShowRewards(List<ItemInfo> itemInfos)
		{
		}

		private void UpdateStatus()
		{
		}

		private bool CanClaim()
		{
			return false;
		}

		private bool IsClaimed()
		{
			return false;
		}
	}
}
