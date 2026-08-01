using System;
using System.Collections.Generic;
using Ssar.Event.DemonInvasion.View;
using UnityEngine;

namespace Ssar.Event.DemonInvasion.Popup
{
	public class DemonInvasionLoginPopup : BasePopup
	{
		public UILabel lb_title;

		public UILabel lb_time;

		public GameObject btn_close;

		[SerializeField]
		private DemonLoginGiftDayView view;

		private List<DemonLoginGiftDayView> dayViews;

		private bool first;

		private DateTime endTime;

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

		private void CreateDayView()
		{
		}
	}
}
