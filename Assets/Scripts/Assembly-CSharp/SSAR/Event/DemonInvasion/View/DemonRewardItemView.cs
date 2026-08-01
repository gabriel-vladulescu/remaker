using Ssar.Event.DemonInvasion.Config;
using UnityEngine;

namespace Ssar.Event.DemonInvasion.View
{
	public class DemonRewardItemView : MonoBehaviour
	{
		public UILabel lb_token;

		public GameObject objTracker;

		public DemonItemPartView item_demon;

		public DemonItemPartView item_normal;

		private DemonInvasionReward reward;

		public void Show(DemonInvasionReward data, bool tracker)
		{
		}

		private void Tracker(bool enable, bool unlockDemonPass, bool hasItemFree)
		{
		}

		private void SetToken(bool avaiable, int token)
		{
		}

		public void EnableAllBox(bool enable)
		{
		}
	}
}
