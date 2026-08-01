using System;
using SSAR.Equipment.Enum;
using Scripts.Config;
using UnityEngine;

namespace SSAR.Shop.View
{
	public class BundlePackageOneProductPlusPopup : BasePopup
	{
		[Serializable]
		public class PlusInfo
		{
			public UISprite sp_bg;

			public UISprite sp_icon;

			public UILabel lb_text;

			public void MaxSize()
			{
			}

			public void MinSize()
			{
			}

			public void Show(EquipmentType type, Rarity rarity, int number, bool isRandom = true)
			{
			}

			public void Hide()
			{
			}

			private string GetTextDes(EquipmentType type, Rarity rarity, bool isRandom)
			{
				return null;
			}

			private string GetBgSpriteName(Rarity rarity)
			{
				return null;
			}

			private string GetIconSpriteName(EquipmentType type, Rarity rarity)
			{
				return null;
			}

			private string UpperToLower(string str)
			{
				return null;
			}

			private string LowerToUpper(string str)
			{
				return null;
			}
		}

		public UILabel lb_title;

		public UILabel lb_price;

		public UILabel lb_priceBase;

		public UILabel lb_available;

		public UILabel lb_sale;

		public UILabel lb_time;

		public UISprite icon_name_text;

		public UILabel buttonText;

		public GameObject wg_sale;

		public GameObject btn_purchase;

		public GameObject btn_close;

		public GameObject btn_previous;

		public GameObject btn_next;

		public GameObject wg_x2;

		public GameObject buttonTest;

		public BundlePackageOneProductEquipmentContainer EquipmentContainer;

		public BundlePackageOneProductResourcesContainer ResourcesContainer;

		private AbsShowPackageInfoParameter parameter;

		public PlusInfo info1;

		public PlusInfo info2;

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

		private void Test(GameObject o)
		{
		}

		private void ShowExtend()
		{
		}

		private void SetConctep()
		{
		}

		public void HideAll(GameObject o)
		{
		}
	}
}
