using SSAR.View;
using Ssar.Craft.Model;
using UnityEngine;

namespace Ssar.Craft.View
{
	public class SellMaterialPopup : BasePopup
	{
		public GameObject wg_item;

		public GameObject wg_sell;

		public GameObject wg_currencyModifier;

		public GameObject btn_close;

		private CraftingMaterialView materialView;

		private ButtonSellView buttonSellView;

		private CurrencyModifierContainer currencyModifierContainer;

		private int currentValue;

		private CraftingMaterial material;

		protected override void Awake()
		{
		}

		protected override bool EnableBack()
		{
			return false;
		}

		private void InitItem()
		{
		}

		private void InitSell()
		{
		}

		private void InitCurrencyModifier()
		{
		}

		private void OnChangeValue(int value)
		{
		}

		private void Sell()
		{
		}

		internal void Show(CraftingMaterial material)
		{
		}
	}
}
