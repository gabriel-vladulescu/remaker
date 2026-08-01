using System;
using UnityEngine;

namespace Ssar.Event.EventLogin.View
{
	public class EventLoginPopup : BasePopup
	{
		public UILabel lb_title;

		public UILabel lb_time;

		public UIGrid dayContainer;

		public GameObject btn_close;

		public GameObject prefab;

		private EventLoginDayView[] dayViews;

		private DateTime endTime;

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		protected override bool EnableBack()
		{
			return false;
		}

		private void Init()
		{
		}

		private void Update()
		{
		}

		private void UpdateTime()
		{
		}

		private void UpdateTimeDisplay()
		{
		}

		private void UpdateData()
		{
		}

		internal void Show()
		{
		}

		internal void Refresh()
		{
		}
	}
}
