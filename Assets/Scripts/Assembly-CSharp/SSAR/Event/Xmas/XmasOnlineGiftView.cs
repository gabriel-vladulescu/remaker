using UnityEngine;

namespace Ssar.Event.Xmas
{
	public class XmasOnlineGiftView : MonoBehaviour
	{
		public GameObject container;

		public UILabel lbTime;

		public GameObject mask;

		public GameObject mask2;

		public GameObject tick;

		public GameObject pointContainer;

		private DungeonRewardView rewardView;

		private OnlineRewardInfo rewardInfo;

		private GameObject fxObj;

		private Collider collider;

		private bool isRefreshed;

		private void Awake()
		{
		}

		internal void Show(OnlineRewardInfo rewardInfo)
		{
		}

		internal void Refresh()
		{
		}

		internal void Hide()
		{
		}

		private ItemInfo ValidateReward(ItemInfo itemInfo)
		{
			return null;
		}

		private void Claim(GameObject go)
		{
		}

		private void Update()
		{
		}

		private void UpdateTime()
		{
		}

		private bool IsClaimed()
		{
			return false;
		}

		private bool IsClaimable()
		{
			return false;
		}

		private bool IsCurrentGift()
		{
			return false;
		}
	}
}
