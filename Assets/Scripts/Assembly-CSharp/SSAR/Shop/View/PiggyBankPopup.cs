using UnityEngine;

namespace SSAR.Shop.View
{
	public class PiggyBankPopup : BasePopup
	{
		public UILabel lb_quantity;

		public UILabel lb_sellPrice;

		public GameObject btn_buy;

		public GameObject btn_close;

		public UILabel lb_title;

		public UILabel lb_itemType;

		public GameObject sp_soul;

		public GameObject sp_crystal;

		public UISprite sp_piggyBankType;

		public UITable tableStar;

		public GameObject bgFxContainer;

		public GameObject topFxContainer;

		private PiggyBankType type;

		private GameObject[] bgFx;

		private GameObject[] topFx;

		protected override void Awake()
		{
		}

		protected override bool EnableBack()
		{
			return false;
		}

		private void Buy(GameObject go)
		{
		}

		public void Show(PiggyBankType piggyBankType)
		{
		}

		private void PlayFx()
		{
		}

		public void OnBuySuccess()
		{
		}

		private void InitFx()
		{
		}

		private void HideFx()
		{
		}
	}
}
