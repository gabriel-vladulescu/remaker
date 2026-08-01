using UnityEngine;

namespace Ssar.Event.Xmas
{
	public class XmasWarPopup : BasePopup
	{
		public UILabel lbPoint;

		public UIGrid milestoneContainer;

		public UIGrid questContainer;

		public GameObject btnClose;

		private XmasWarMilestoneView[] milestoneViews;

		private XmasWarQuestView[] questViews;

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

		internal void Show()
		{
		}

		private void Init()
		{
		}

		private void UpdateData()
		{
		}

		internal void UpdateMilestone()
		{
		}

		private void UpdateQuestDesc()
		{
		}
	}
}
