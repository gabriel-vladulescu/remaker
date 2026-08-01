using System.Collections.Generic;
using SSAR.Equipment.Enum;
using Ssar.Rune.Model;

namespace Scripts.Config
{
	public class RuneConfig : IConfig
	{
		public class RuneItemConfig
		{
			public string runeType;

			public string runeRarity;

			public int stackCount;

			public int lowerRuneCombinationRequirement;

			public int soulCostForCombination;

			public int lowerRuneDisassemblingRate;

			private RuneType runeTypeValue;

			private bool runeTypeValueParsed;

			private RuneRarity runeRarityValue;

			private bool runeRarityValueParsed;

			public RuneType RuneTypeValue()
			{
				return default(RuneType);
			}

			public RuneRarity RuneRarityValue()
			{
				return default(RuneRarity);
			}
		}

		public class RuneStatsBySlot
		{
			public int id;

			public string runeType;

			public string equipmentType;

			public string statsType;

			public string[] statsValues;

			private RuneType runeTypeValue;

			private bool runeTypeValueParsed;

			private EquipmentType equipmentTypeValue;

			private bool equipmentTypeValueParsed;

			private StatType statTypeValue;

			private bool statTypeValueParsed;

			private StatsValue[] parsedStatsValues;

			public StatsValue[] ParsedStatsValues
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public void Parse()
			{
			}

			public bool FindStatsValueOfRuneRarity(RuneRarity rarity, ref double statsValue)
			{
				return false;
			}

			public RuneType RuneTypeValue()
			{
				return default(RuneType);
			}

			public EquipmentType EquipmentTypeValue()
			{
				return default(EquipmentType);
			}

			public StatType StatTypeValue()
			{
				return default(StatType);
			}
		}

		public class StatsValue
		{
			public RuneRarity runeRarity;

			public double value;

			public StatsValue(RuneRarity runeRarity, double value)
			{
			}
		}

		public class StatsValue2
		{
			public int id;

			public string statsType;

			public string rarity;

			public double statsValue;

			public StatType StatTypeValue()
			{
				return default(StatType);
			}

			public RuneRarity RarityValue()
			{
				return default(RuneRarity);
			}
		}

		public class RunePriceConstant
		{
			public double sellPriceConstant { get; set; }

			public double reforgePriceConstant { get; set; }
		}

		public class RuneUnequipPriceConstant
		{
			public double unequipPriceConstant { get; set; }
		}

		public class RuneSellPriceBase
		{
			public double priceBase { get; set; }
		}

		public class RuneEnhanceStatToSoulConstant
		{
			public double perStatToSoulConstant { get; set; }
		}

		public Dictionary<string, RuneItemConfig> runes;

		public Dictionary<string, RuneStatsBySlot> runeStatsBySlots;

		public Dictionary<string, StatsValue2> statsValues;

		public Dictionary<string, RunePriceConstant> priceConstants;

		public Dictionary<string, RuneSellPriceBase> priceBases;

		public Dictionary<string, RuneEnhanceStatToSoulConstant> mainStatToSoulConstants;

		public Dictionary<string, RuneUnequipPriceConstant> unequipRunePriceConstants;

		private RuneItemConfig[] runeItemConfigs;

		private Dictionary<string, RuneStatsBySlot> runeStatsByRuneTypeAndEquipmentType;

		private Dictionary<string, RuneItemConfig> runeItemConfigsByRuneTypeAndRarity;

		public void OnMapValue(string content)
		{
		}

		private List<StatsValue2> FindStatsValue2(StatType statType)
		{
			return null;
		}

		private string Key(RuneType runeType, EquipmentType equipmentType)
		{
			return null;
		}

		public bool FindRuneStatsBySlot(RuneType runeType, EquipmentType equipmentType, ref RuneStatsBySlot stats)
		{
			return false;
		}

		public bool FindLowerRuneRequirementForCombination(RuneType runeType, RuneRarity runeRarity, int amount, ref int requirement)
		{
			return false;
		}

		public bool FindDisassemblingResult(RuneType runeType, RuneRarity runeRarity, int amount, ref int count)
		{
			return false;
		}

		public bool FindSellPrice(RuneType runeType, RuneRarity runeRarity, ref int price)
		{
			return false;
		}

		public RuneItemConfig FindRuneItemConfig(RuneType type, RuneRarity rarity)
		{
			return null;
		}

		public RunePriceConstant GetRunePriceConstant(RuneType type)
		{
			return null;
		}

		public RuneUnequipPriceConstant GetRuneUnequipPriceConstant(RuneType type)
		{
			return null;
		}

		public RuneSellPriceBase GetRuneSellPriceBase(RuneType type, RuneRarity rarity)
		{
			return null;
		}

		public RuneEnhanceStatToSoulConstant GetRuneStatToSoulConstant(RuneType type)
		{
			return null;
		}
	}
}
