using Scripts.Config;
using UnityEngine;

namespace Ssar.Event.DemonInvasion.View
{
	public class DemonItemPartView : MonoBehaviour
	{
		public UISprite sp_icon;

		public UISprite sp_cover;

		public BoxCollider collider;

		public UISprite sp_lock;

		public UILabel lb_name;

		private DemonGiftType giftType;

		private DemonItemType itemType;

		private int id;

		private int day;

		private bool enableBox;

		private ParticleRunAroundFx particleRunAroundFx;

		private ParticleSystem particleSystem;

		private bool firstTime;

		public bool EnableBox
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private void Awake()
		{
		}

		private void OnClick(GameObject go)
		{
		}

		public void ShowReward(DemonItemType type, ItemInfo item, int id, bool avaiable, bool received)
		{
		}

		public void PlayEffect(bool play)
		{
		}

		public void ShowGift(DemonItemType type, ItemInfo item, int day, int value, bool avaiable, bool received, bool proBoard)
		{
		}

		private void TextName(ConfigManager configManager, ItemInfo item)
		{
		}

		private void ResizeIcon(ConfigManager configManager, ItemInfo item)
		{
		}

		private void CreateFx()
		{
		}

		private void SetCoverReward(bool avaiable, bool received)
		{
		}

		private void SetBackgroundGift(bool proBoard)
		{
		}
	}
}
