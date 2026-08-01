using Scripts.Config;
using UnityEngine;

namespace SSAR.Shop.View
{
	public class AncientEquipmentPackagePopup : BasePopup
	{
		public UILabel lb_title;

		public UILabel lb_price;

		public UILabel lb_priceBase;

		public UILabel lb_available;

		public UILabel lb_sale;

		public UISprite icon_name_text;

		public UILabel buttonText;

		public GameObject wg_sale;

		public GameObject btn_purchase;

		public GameObject btn_close;

		public GameObject btn_previous;

		public GameObject btn_next;

		public GameObject wg_x2;

		public BundlePackageOneProductResourcesContainer ResourcesContainer;

		public AncientEquipmentPackageItemContainer ancientContainer;

		private AbsShowPackageInfoParameter parameter;

		protected override void Awake()
		{
		}

		public void Show(AbsShowPackageInfoParameter parameter)
		{
		}

		protected override void OnDisable()
		{
		}

		protected override void OnDestroy()
		{
		}

		private void UpdateData()
		{
		}

		public void BoughtProduct(BundlePackageProductInfo productInfo)
		{
		}

		private void ShowInfo()
		{
		}

		private new void Hide(GameObject o)
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

		private void Next(GameObject o)
		{
		}

		private void Previous(GameObject o)
		{
		}

		private string GetTitle()
		{
			return null;
		}
	}
}
