using System.Collections.Generic;
using LitJson;
using SSAR.Equipment.Enum;

namespace Scripts.Config
{
	public class ShopVendorConfig : IConfig
	{
		public class RandomEquipment
		{
			public int id;

			public string[] grades;

			public string[] rarities;

			public string[] types;

			public GradeDropPercentage[] GradeDropPercentages()
			{
				return null;
			}

			public RarityDropPercentage[] RarityDropPercentages()
			{
				return null;
			}

			public TypeDropPercentage[] TypeDropPercentages()
			{
				return null;
			}
		}

		public class GradeDropPercentage
		{
			private string rawValue;

			private EquipmentTier grade;

			private int percentage;

			public string RawValue => null;

			public EquipmentTier Grade => default(EquipmentTier);

			public int Percentage => 0;

			public GradeDropPercentage(string rawValue)
			{
			}
		}

		public class RarityDropPercentage
		{
			private string rawValue;

			private Rarity rarity;

			private int percentage;

			public string RawValue => null;

			public Rarity Rarity => default(Rarity);

			public int Percentage => 0;

			public RarityDropPercentage(string rawValue)
			{
			}
		}

		public class TypeDropPercentage
		{
			private string rawValue;

			private EquipmentType type;

			private int percentage;

			public string RawValue => null;

			public EquipmentType Type => default(EquipmentType);

			public int Percentage => 0;

			public TypeDropPercentage(string rawValue)
			{
			}
		}

		public Dictionary<string, ShopVendorProductInfo> items;

		public Dictionary<string, ShopVendorRefreshInfo> refreshInfo;

		private Dictionary<int, List<ShopVendorProductInfo>> cache;

		private ShopVendorRefreshInfo refresh;

		public void OnMapValue(string content)
		{
		}

		private T MapData<T>(JsonData data) where T : class
		{
			return null;
		}

		private List<ShopVendorProductInfo> SortDictionary(Dictionary<string, ShopVendorProductInfo> dict)
		{
			return null;
		}

		public List<ShopVendorProductInfo> GetListShopVendorProductInfos(int characterLevel)
		{
			return null;
		}

		public ShopVendorProductInfo GetProductInfo(int characterLv, int productId)
		{
			return null;
		}

		public ShopVendorRefreshInfo GetShopVendorRefreshInfo()
		{
			return null;
		}
	}
}
