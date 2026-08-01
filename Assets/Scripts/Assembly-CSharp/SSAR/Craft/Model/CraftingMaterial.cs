using System;
using CodeStage.AntiCheat.ObscuredTypes;
using LitJson;
using SSAR.Entry.Model;
using SSAR.Equipment.Enum;
using Ssar.Craft.Enum;

namespace Ssar.Craft.Model
{
	[Serializable]
	public class CraftingMaterial : ICollectData
	{
		public Rarity rarity;

		public CraftingMaterialType type;

		public CraftingMaterialLogData CraftingMaterialLogData;

		[JsonInclude]
		private ObscuredInt mCount;

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

		public int collectID { get; set; }

		[JsonIgnore]
		public CollectType collectType
		{
			get
			{
				return default(CollectType);
			}
			set
			{
			}
		}

		[JsonIgnore]
		public int Quantity => 0;

		[JsonIgnore]
		public Rarity Rarity => default(Rarity);

		[JsonIgnore]
		public CraftingMaterialType Type => default(CraftingMaterialType);

		public CraftingMaterial()
		{
		}

		public CraftingMaterial(int collectId, int quantity, CraftingMaterialType type, Rarity rarity)
		{
		}

		public bool Add(int amount, RewardReason reason)
		{
			return false;
		}

		public bool Consume(int amount, ConsumeCraftingMaterialReason reason)
		{
			return false;
		}

		public bool IsIncreasableBy(int amount)
		{
			return false;
		}

		public bool IsConsumable(int amount)
		{
			return false;
		}
	}
}
