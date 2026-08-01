using System.Collections.Generic;
using Scripts.Config;
using UnityEngine;

namespace Ssar.Event.EventPopup
{
	public class EventPopupMoreThanRowView : MonoBehaviour
	{
		[SerializeField]
		private GameObject btn_claim;

		[SerializeField]
		private GameObject btn_tick;

		[SerializeField]
		private UILabel lb_desc;

		[SerializeField]
		private UILabel lb_progress;

		[SerializeField]
		private UILabel lb_claim;

		[SerializeField]
		private EventItemView[] rewardItemViews;

		private List<MoreThanCrystalReward> _rewardInfos;

		private EventContainer _container;

		private ResourceType _resourceType;

		private IEventData _eventData;

		private bool _canClaim;

		private int _productId;

		private int _price;

		private void Awake()
		{
		}

		private void Claim(GameObject go)
		{
		}

		public void Show(EventContainer container, MoreThanCrystalInfo eventInfo, List<MoreThanCrystalReward> rewardInfos, IEventData eventData, ResourceType resource)
		{
		}
	}
}
