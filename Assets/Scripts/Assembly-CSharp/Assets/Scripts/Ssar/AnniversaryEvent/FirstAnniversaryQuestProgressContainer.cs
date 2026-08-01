using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Ssar.AnniversaryEvent
{
	public class FirstAnniversaryQuestProgressContainer : MonoBehaviour
	{
		public UILabel lb_count;

		public UISlider progress;

		public UIWidget[] mileStones;

		private List<FirstAnniversaryQuestMilestoneView> milestoneViews;

		private void Awake()
		{
		}

		private void Init()
		{
		}

		public void UpdateData(FirstAnniversaryQuestData data)
		{
		}
	}
}
