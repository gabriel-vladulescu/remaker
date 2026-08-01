using System.Collections.Generic;
using LitJson;

namespace Assets.Scripts.Ssar.Shop.Model
{
	public class FirstTopUpBoughtData
	{
		[JsonInclude]
		private List<string> skuOfProductBought;

		[JsonInclude]
		private bool hasNewItem;

		public bool HasBoughtOneProduct()
		{
			return false;
		}

		public void AddSkuBought(string sku)
		{
		}

		public bool HasNewItem()
		{
			return false;
		}

		public void SetFirstTopUpHasNewItem(bool hasNewItem)
		{
		}
	}
}
