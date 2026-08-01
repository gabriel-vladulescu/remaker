using Scripts.Config;
using UnityEngine;

namespace Scripts.Ssar.Arena
{
	public class RewardListItemView : MonoBehaviour
	{
		public UILabel lb_number;

		public UISprite sp_icon;

		public UILabel lb_name;

		private ConfigManager configManager;

		private Color colorDefault;

		private void Awake()
		{
		}

		public void Show(ItemInfo itemInfo)
		{
		}

		public void Hide()
		{
		}
	}
}
