using Scripts.Config;
using UnityEngine;

namespace Ssar.Event.EventPopup
{
	public class EventPopupPackView : MonoBehaviour
	{
		public UILabel lb_title;

		public UILabel lb_price;

		public UILabel lb_available;

		public UISprite sp_icon;

		private QuinnRequestPackInfo _packInfo;

		private QuinnRequestEventData _eventData;

		private QuinnRequestContainer _container;

		private void Awake()
		{
		}

		private void Click(GameObject o)
		{
		}

		private void Buy()
		{
		}

		public void Show(QuinnRequestContainer container, QuinnRequestPackInfo packInfo, QuinnRequestEventData eventData)
		{
		}

		private string GetTextAvailable(QuinnRequestPackInfo packInfo)
		{
			return null;
		}

		private bool IsReachLimit(QuinnRequestPackInfo packInfo)
		{
			return false;
		}

		private int PurchasedCount(QuinnRequestPackInfo packInfo)
		{
			return 0;
		}
	}
}
