using SSAR.Equipment.View;
using Scripts.Config;
using UnityEngine;

namespace Assets.Scripts.Mastery
{
	public class TrainMasterySuccessPopup : BasePopup
	{
		public GameObject simpleInfoContainer;

		public GameObject detailContainer;

		public GameObject finishFxContainer;

		public GameObject btnClick;

		public GameObject mas;

		public GameObject btn_close;

		public UIPanel detailPane;

		public TweenScale light;

		public TweenScale info;

		public UILabel lb_name;

		public UILabel lb_lv;

		public UILabel lb_progress;

		public UISprite sp_icon;

		public UITable table_stat;

		public UIProgressBar progress;

		private UIWidget[] widgets;

		private UIPanel panel;

		private EquipmentSubstatView substatView;

		protected override void Awake()
		{
		}

		protected override void onEnable()
		{
		}

		protected override bool EnableBack()
		{
			return false;
		}

		protected override void ExecuteBack()
		{
		}

		public void Show(MasteryInfo masteryInfo, float level)
		{
		}

		private void Init()
		{
		}

		private void DisableWidget(bool disable)
		{
		}

		private void Close(GameObject o)
		{
		}

		private void Close()
		{
		}
	}
}
