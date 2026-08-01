using System.Collections.Generic;
using SSAR.Equipment.Enum;

namespace Scripts.Config
{
	public class EquipmentConfig : IConfig
	{
		public Dictionary<string, EquipmentEnhanceStatConstant> statEnhanceConstants;

		public Dictionary<string, EquipmentEnhanceStatToSoulConstant> mainStatToSoulConstants;

		public Dictionary<string, EquipmentSellPriceBase> priceBases;

		public Dictionary<string, EquipmentSellPriceConstant> sellPriceConstants;

		public Dictionary<string, EquipmentStatPropertyName> propertyNames;

		public Dictionary<string, EquipmentReforgeConstant> reforge;

		public Dictionary<string, EquipmentVisualAvailableInfo> visualAvailable;

		private Dictionary<string, Dictionary<string, List<int>>> dictVisualIdAvailable;

		public void OnMapValue(string content)
		{
		}

		public EquipmentSellPriceBase GetEquipmentSellPriceBase(EquipmentType type, EquipmentTier tier, Rarity rarity)
		{
			return null;
		}

		public EquipmentEnhanceStatToSoulConstant GetEquipmentEnhanceStatToSoulConstant(EquipmentType type)
		{
			return null;
		}

		public EquipmentEnhanceStatConstant GetEquipmentEnhanceStatConstant(EquipmentType type, EquipmentTier tier, Rarity rarity)
		{
			return null;
		}

		public EquipmentSellPriceConstant GetEquipmentSellPriceConstant(EquipmentType type)
		{
			return null;
		}

		public EquipmentStatPropertyName GetEquipmentStatPropertyName(StatType statType)
		{
			return null;
		}

		public EquipmentReforgeConstant GetEquipmentReforgeConstant(Rarity rarity)
		{
			return null;
		}
	}
}
