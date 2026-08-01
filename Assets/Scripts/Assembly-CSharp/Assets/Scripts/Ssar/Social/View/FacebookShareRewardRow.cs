using UnityEngine;

namespace Assets.Scripts.Ssar.Social.View
{
	public class FacebookShareRewardRow : MonoBehaviour
	{
		public UILabel lb_title;

		public UILabel lb_quantity;

		public UISprite sp_icon;

		public UITable table;

		public GameObject wg_received;

		public void Show(int min, int max, int cur, ItemInfo itemInfo)
		{
		}

		public void Hide()
		{
		}

		private string GetLbTitle(int min, int max)
		{
			return null;
		}

		private string GetRank(int number)
		{
			return null;
		}
	}
}
