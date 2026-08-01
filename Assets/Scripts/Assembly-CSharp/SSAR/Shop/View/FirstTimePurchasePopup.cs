using System.Collections.Generic;
using UnityEngine;

namespace SSAR.Shop.View
{
	public class FirstTimePurchasePopup : BasePopup
	{
		public GameObject btn_close;

		public UITable table;

		private List<FirstTimePurchasePopupItemView> itemViews;

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

		private void InitItem()
		{
		}
	}
}
