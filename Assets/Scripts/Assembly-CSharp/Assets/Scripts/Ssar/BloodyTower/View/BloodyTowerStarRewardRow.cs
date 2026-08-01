using UnityEngine;

namespace Assets.Scripts.Ssar.BloodyTower.View
{
	public class BloodyTowerStarRewardRow : MonoBehaviour
	{
		public UILabel lb_desc;

		public GameObject rewardContainer;

		public GameObject wgReceived;

		private RewardReceiveView ReceiveView;

		private void Awake()
		{
		}

		public void Show(int floor, int star)
		{
		}

		private bool IsClaimed(int floor, int star)
		{
			return false;
		}
	}
}
