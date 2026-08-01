using Scripts.Config;
using UnityEngine;

namespace Ssar.Event.SevenDaysCampaign.View
{
	public class CampaignRowView : AbsQuestRowView
	{
		public UIGrid rewardContainer;

		private CampaignConfig.CampaignQuestItem questItem;

		private CampaignRowRewardView[] rewardViews;

		protected override void Awake()
		{
		}

		public override void OnShow(WrapContentData data, int index)
		{
		}

		protected override void ClickClaim(GameObject o)
		{
		}

		protected override bool HasClaimed()
		{
			return false;
		}

		protected override bool CanClaim()
		{
			return false;
		}

		protected override int QuestRequire()
		{
			return 0;
		}

		protected override int CurProgress()
		{
			return 0;
		}

		protected override ItemInfo RewardItemInfo()
		{
			return null;
		}

		protected override string AchivementIcon()
		{
			return null;
		}

		protected override string QuestName()
		{
			return null;
		}

		protected override string QuestDesc()
		{
			return null;
		}

		private ItemInfo[] GetRewards()
		{
			return null;
		}
	}
}
