using System;
using Assets.Scripts.Ssar.AnniversaryEvent;
using UnityEngine;

namespace Ssar.Event.Xmas
{
	public class XmasLoginPopup : BasePopup
	{
		public UILabel lb_title;

		public UILabel lb_time;

		public UIGrid dayContainer;

		public GameObject btn_close;

		public GameObject prefab;

		private FirstAnniversaryLoginDayView[] dayViews;

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

		public void Show()
		{
		}

		private void Init()
		{
		}

		private void UpdateTime()
		{
		}

		internal void UpdateData()
		{
		}

		private void Update()
		{
		}

		private void UpdateTimeDisplay()
		{
		}
	}
}
