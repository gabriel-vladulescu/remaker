using UnityEngine;

namespace Ssar.Event.Xmas
{
	public class XmasWarMilestoneView : MonoBehaviour
	{
		public GameObject container;

		public UILabel lbPoint;

		public GameObject mask;

		public GameObject mask2;

		public GameObject tick;

		public GameObject pointContainer;

		private DungeonRewardView rewardView;

		private XmasWarMilestone milestone;

		private GameObject fxObj;

		private Collider collider;

		private void Awake()
		{
		}

		internal void Show(XmasWarMilestone milestone, bool isNextMilestone)
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

		private bool IsClaimable()
		{
			return false;
		}

		private bool IsClaimed()
		{
			return false;
		}
	}
}
