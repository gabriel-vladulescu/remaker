using System.Collections.Generic;
using Assets.Scripts.Config.Stats;
using SSAR.Equipment.Enum;

namespace Scripts.Config
{
	public class PetConfig : IConfig
	{
		public Dictionary<string, PetBasicStats> basic;

		public Dictionary<string, PetSkillStats> skillStats;

		public Dictionary<string, EquipmentEnhanceStatConstant> statEnhanceConstants;

		public Dictionary<string, EquipmentEnhanceStatToSoulConstant> mainStatToSoulConstants;

		public Dictionary<string, EquipmentSellPriceBase> priceBases;

		public Dictionary<string, EquipmentSellPriceConstant> sellPriceConstants;

		public Dictionary<string, AwakenEquipmentExpInfo> awakenInfos;

		public Dictionary<string, AwakenEquipmentConstant> awakenConstant;

		public void OnMapValue(string content)
		{
		}

		public HeroBasicStats FindHeroAdvanceStats(int groupId, int id)
		{
			return null;
		}

		public List<string> ListAllSkillsBy(int groupId, int id, bool isActiveSkill = true)
		{
			return null;
		}

		public AbsHeroConfig.SkillStats FindSkillStatsById(string id)
		{
			return null;
		}

		public List<string> ListAllActiveAndPassiveSkills(int groupId, int subId)
		{
			return null;
		}

		public AwakenEquipmentExpInfo GetAwakenEquipmentExpInfo(Rarity rarity, EquipmentTier tier)
		{
			return null;
		}

		public AwakenEquipmentConstant GetAwakenEquipmentConstant()
		{
			return null;
		}

		public EquipmentSellPriceBase GetEquipmentSellPriceBase(EquipmentTier tier, Rarity rarity)
		{
			return null;
		}

		public EquipmentEnhanceStatToSoulConstant GetEquipmentEnhanceStatToSoulConstant(StatType statType)
		{
			return null;
		}

		public EquipmentEnhanceStatConstant GetEquipmentEnhanceStatConstant(EquipmentTier tier, Rarity rarity)
		{
			return null;
		}

		public EquipmentSellPriceConstant GetEquipmentSellPriceConstant()
		{
			return null;
		}

		public List<PetSkillStats> GetAllSkillStatses(int groupId, int subId)
		{
			return null;
		}

		public PetSkillStats GetSkillStats(int groupId, int subId, int skillId)
		{
			return null;
		}

		private int Comparer(AbsHeroConfig.SkillStats a, AbsHeroConfig.SkillStats b)
		{
			return 0;
		}
	}
}
