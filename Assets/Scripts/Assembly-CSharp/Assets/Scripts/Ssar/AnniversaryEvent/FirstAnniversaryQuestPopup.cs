using System;
using UnityEngine;

namespace Assets.Scripts.Ssar.AnniversaryEvent
{
	public class FirstAnniversaryQuestPopup : BasePopup
	{
		public GameObject wg_progress;

		public GameObject wg_reward;

		public GameObject btn_close;

		public UILabel lb_eventRemaining;

		public UILabel lb_nextDay;

		private FirstAnniversaryQuestProgressContainer progressContainer;

		private FirstAnniversaryQuestRewardContainer rewardContainer;

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

		public void UpdateData()
		{
		}

		private void Init()
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
