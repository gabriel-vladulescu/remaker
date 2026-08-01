using System.Collections.Generic;
using UnityEngine;

namespace Scripts.Ssar.Arena
{
	public class RewardListRowView : MonoBehaviour
	{
		public UILabel lb_rank;

		public UITable table;

		public GameObject Received_Spr;

		private RewardListItemView[] rewardViews;

		private RewardListRowData rowData;

		private RewardPromotionListRowData rowPromotionData;

		private int seasonCode;

		private void Awake()
		{
		}

		public void Show(int index, RewardPromotionListRowData rewardPromotionListRowData)
		{
		}

		public void Show(int index, RewardListRowData rewardListRowData, int seasonCode)
		{
		}

		private void ShowReward(List<ItemInfo> itemInfos)
		{
		}

		private void ShowEquipment(RewardListItemView rewardView, string spriteName, int quantity)
		{
		}

		public void Hide()
		{
		}

		public void UpdateTextColor(int index)
		{
		}

		private void Seperate(List<ItemInfo> itemInfos, out ItemInfo crystal, out List<ItemInfo> equipment, out List<ItemInfo> randomRune)
		{
			crystal = null;
			equipment = null;
			randomRune = null;
		}
	}
}
