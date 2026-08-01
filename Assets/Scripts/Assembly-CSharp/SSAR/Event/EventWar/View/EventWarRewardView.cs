using Scripts.Config;
using UnityEngine;

namespace Ssar.Event.EventWar.View
{
	public class EventWarRewardView : MonoBehaviour
	{
		public GameObject container;

		public UILabel lbPoint;

		public GameObject mask;

		public GameObject mask2;

		public GameObject tick;

		public GameObject pointContainer;

		private DungeonRewardView rewardView;

		private GameObject fxObj;

		private Collider collider;

		private EventWarReward reward;

		private void Awake()
		{
		}

		internal void Show(EventWarReward reward, bool isNextReward)
		{
		}

		internal void Hide()
		{
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
