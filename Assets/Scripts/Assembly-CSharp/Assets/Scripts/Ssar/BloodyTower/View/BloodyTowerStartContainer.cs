using Scripts.Config;
using UnityEngine;

namespace Assets.Scripts.Ssar.BloodyTower.View
{
	public class BloodyTowerStartContainer : MonoBehaviour
	{
		public UILabel lb_stamina;

		public UILabel lb_name;

		public GameObject wgReceived;

		public BloodyTowerStarRewardRow[] StarRewardRows;

		public UILabel[] lb_rules;

		public GameObject btn_start;

		public GameObject btn_startLock;

		public int floor;

		private void Awake()
		{
		}

		public void Show(int floor)
		{
		}

		public void Hide()
		{
		}

		private ConfigManager GetConfigManager()
		{
			return null;
		}

		private void Enter(GameObject o)
		{
		}

		private void ShowStarPreview()
		{
		}

		private void Lock(GameObject o)
		{
		}

		private bool IsEnoughLevel()
		{
			return false;
		}

		private int LevelRequireUnlockBloodyTower()
		{
			return 0;
		}

		private bool IsUnlock()
		{
			return false;
		}

		private bool IsClaimedAllReward()
		{
			return false;
		}
	}
}
