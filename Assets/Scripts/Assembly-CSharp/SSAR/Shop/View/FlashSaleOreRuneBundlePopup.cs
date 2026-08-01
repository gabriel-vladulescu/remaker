using System;
using Scripts.Config;
using UnityEngine;

namespace SSAR.Shop.View
{
	public class FlashSaleOreRuneBundlePopup : BasePopup
	{
		public UILabel lb_price;

		public UILabel lb_priceBase;

		public UILabel lb_sale;

		public GameObject btn_close;

		public GameObject btn_purchase;

		private FlashSaleOreRuneBundleProductInfo productInfo;

		private Action onClose;

		protected override void Awake()
		{
		}

		public void Show(FlashSaleOreRuneBundleProductInfo productInfo, Action onClose)
		{
		}

		protected override bool EnableBack()
		{
			return false;
		}

		protected override void ExecuteBack()
		{
		}

		private void Buy(GameObject o)
		{
		}
	}
}
