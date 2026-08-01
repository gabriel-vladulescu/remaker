using UnityEngine;

namespace Ssar.Event.EventPopup
{
	public class EventPopup : BasePopup
	{
		public GameObject btn_close;

		public GameObject backgroundMask;

		public UITable tabTable;

		public UIScrollView tabScrollView;

		public EventClickItem[] eventTabs;

		public EventContainer[] eventContainers;

		private int currentTab;

		protected override void Awake()
		{
		}

		protected override bool EnableBack()
		{
			return false;
		}

		public void Show()
		{
		}

		private void InitEvent()
		{
		}

		private void OnSelectEvent(int index)
		{
		}
	}
}
