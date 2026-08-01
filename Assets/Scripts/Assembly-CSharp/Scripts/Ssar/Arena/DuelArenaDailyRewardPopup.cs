using System.Collections.Generic;
using UnityEngine;

namespace Scripts.Ssar.Arena
{
	public class DuelArenaDailyRewardPopup : BasePopup
	{
		public GameObject btn_close;

		public UITable table_reward;

		private List<DailyRewardRowView> rowviews;

		protected override void Awake()
		{
		}

		protected override bool EnableBack()
		{
			return false;
		}

		protected override void ExecuteBack()
		{
		}

		public void Show()
		{
		}

		private void InitScrollView()
		{
		}
	}
}
