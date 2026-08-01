using System.Collections.Generic;
using CodeStage.AntiCheat.ObscuredTypes;
using SSAR.Equipment.Enum;
using Ssar.Craft.Enum;
using Ssar.Craft.Model;
using Ssar.Rune.Model;

namespace Scripts.Config
{
	public class CraftConfig : IConfig
	{
		public class CraftingMaterialInfo
		{
			public int id;

			public string type;

			public string rarity;

			public double sellPriceConstant;

			public CraftingMaterialType Type => default(CraftingMaterialType);

			public Rarity Rarity => default(Rarity);

			public float SellPriceConstant => 0f;
		}

		public class ExtractFormula
		{
			public string type;

			public string rarity;

			public string[] materialRarity;

			public int[] materialQuantity;

			private RarityRate[] rarityRates;

			public ItemType Type => default(ItemType);

			public Rarity Rarity => default(Rarity);

			public int[] MaterialQuantity => null;

			public RarityRate[] RarityRates => null;

			public void Parse()
			{
			}
		}

		public class RarityRate
		{
			private Rarity rarity;

			private double rate;

			public Rarity Rarity => default(Rarity);

			public double Rate
			{
				get
				{
					return 0.0;
				}
				set
				{
				}
			}

			public RarityRate(string raw)
			{
			}

			public RarityRate(Rarity rarity, double rate)
			{
			}
		}

		public class CraftRecipe
		{
			public int id;

			public string type;

			public string subType;

			public string rarity;

			public string[] requiredMaterials;

			public double soulCost;

			public int craftTime;

			private CraftRequiredMaterial[] parsedRequiredMaterials;

			public int Id => 0;

			public ItemType Type => default(ItemType);

			public string SubType => null;

			public EquipmentType EquipmentType => default(EquipmentType);

			public RuneType RuneType => default(RuneType);

			public Rarity Rarity => default(Rarity);

			public CraftRequiredMaterial[] RequiredMaterials => null;

			public float SoulCost => 0f;

			public void Parse()
			{
			}
		}

		public class CraftRequiredMaterial
		{
			private Rarity rarity;

			private int quantity;

			public Rarity Rarity => default(Rarity);

			public int Quantity => 0;

			public CraftRequiredMaterial(string raw)
			{
			}
		}

		public class CraftInitReward
		{
			private ObscuredInt obscuredConfigId;

			private ObscuredInt obscuredQuantity;

			public int id { get; set; }

			public string feature { get; set; }

			public string rewardType { get; set; }

			public int configId
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public int quantity
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public Feature GetFeature()
			{
				return default(Feature);
			}

			public ItemType GetItemType()
			{
				return default(ItemType);
			}

			public ItemInfo ParseToItemInfo()
			{
				return null;
			}
		}

		public enum Feature
		{
			CRAFT = 0,
			SALVAGE = 1
		}

		public Dictionary<string, CraftingMaterialInfo> materials;

		public Dictionary<string, ExtractFormula> extractFormulas;

		public Dictionary<string, CraftRecipe> craftRecipes;

		public Dictionary<string, CraftInitReward> initRewards;

		public void OnMapValue(string content)
		{
		}

		public CraftingMaterialInfo GetMaterialInfo(int configID)
		{
			return null;
		}

		public CraftingMaterialInfo GetMaterialInfo(CraftingMaterialType type, Rarity rarity)
		{
			return null;
		}

		public ExtractFormula GetExtractFormula(ItemType type, Rarity rarity)
		{
			return null;
		}

		public ExtractFormula[] GetAllExtractFormulas()
		{
			return null;
		}

		public CraftRecipe[] GetAllCraftRecipes()
		{
			return null;
		}

		public CraftRecipe GetCraftRecipe(int recipeID)
		{
			return null;
		}

		public CraftRecipe[] GetCraftRecipeByRule(IGetCraftRecipeRule rule)
		{
			return null;
		}

		public CraftInitReward[] GetInitRewards(Feature feature)
		{
			return null;
		}
	}
}
