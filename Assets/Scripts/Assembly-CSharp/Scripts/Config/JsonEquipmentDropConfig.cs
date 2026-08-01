using System.Collections.Generic;
using Assets.Scripts.Config;
using SSAR.Equipment.Enum;
using SSAR.Equipment.Model;

namespace Scripts.Config
{
	public class JsonEquipmentDropConfig : IConfig
	{
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

		public class DropRateByMonster
		{
			private string rawValue;

			private MonsterId monsterId;

			private int percentage;

			public string RawValue => null;

			public MonsterId MonsterId => null;

			public int Percentage => 0;

			public DropRateByMonster(string rawValue)
			{
			}
		}

		public class MainStats
		{
			public int id;

			public int grade;

			public string rarity;

			public double min;

			public double max;

			public Rarity Rarity => default(Rarity);

			public EquipmentTier Grade => default(EquipmentTier);
		}

		public class BonusStatsType
		{
			public int id;

			public string equipmentType;

			public string statsType;

			public bool availability;

			public EquipmentType EquipmentType => default(EquipmentType);

			public StatType StatsType => default(StatType);
		}

		public class BonusStatsQuantity
		{
			public int id;

			public string rarity;

			public int[] quantity;

			public Rarity Rarity => default(Rarity);
		}

		public class BonusStatsValue
		{
			public int id;

			public string rarity;

			public string statsType;

			public double[] value;

			public double[] oldValue;

			public Rarity Rarity => default(Rarity);

			public StatType StatsType => default(StatType);
		}

		public class WeaponActiveSkill
		{
			public int id;

			public string characterId;

			public int grade;

			public string rarity;

			public string[] skillCounts;

			public string[] skillIds;

			public string[] skillLevels;

			private SkillCountRate[] skillCountValues;

			private SkillIdRate[] skillIdValues;

			private SkillLevelsBySkillId[] skillLevelsBySkillIdsValues;

			public SkillCountRate[] SkillCountValues => null;

			public SkillIdRate[] SkillIdValues => null;

			public SkillLevelsBySkillId[] SkillLevelsBySkillIdsValues => null;

			public void Parse()
			{
			}

			public Rarity RarityValue()
			{
				return default(Rarity);
			}
		}

		public class SkillCountRate
		{
			private int count;

			private double rate;

			public int Count => 0;

			public double Rate => 0.0;

			public SkillCountRate()
			{
			}

			public SkillCountRate(int count, double rate)
			{
			}

			public SkillCountRate(string raw)
			{
			}
		}

		public class SkillIdRate
		{
			private int id;

			private double rate;

			public int Id => 0;

			public double Rate => 0.0;

			public SkillIdRate()
			{
			}

			public SkillIdRate(int id, double rate)
			{
			}

			public SkillIdRate(string raw)
			{
			}
		}

		public class SkillLevelRate
		{
			private int level;

			private double rate;

			public int Level => 0;

			public double Rate => 0.0;

			public SkillLevelRate()
			{
			}

			public SkillLevelRate(int level, double rate)
			{
			}

			public SkillLevelRate(string raw)
			{
			}
		}

		public class SkillLevelsBySkillId
		{
			private int skillId;

			private SkillLevelRate[] skillLevelRates;

			public int SkillId => 0;

			public SkillLevelRate[] SkillLevelRates => null;

			public SkillLevelsBySkillId()
			{
			}

			public SkillLevelsBySkillId(int skillId, SkillLevelRate[] skillLevelRates)
			{
			}

			public SkillLevelsBySkillId(int skillId, string[] rawSkillLevels)
			{
			}
		}

		public class WeaponActiveSkillStats
		{
			public int id;

			public string characterId;

			public int skillId;

			public int skillLevel;

			public double power;

			public double cooldownReduction;

			public string localizeDescInSkillManager;

			public string localizeDesc { get; set; }
		}

		public class WeaponActiveSkillAvailability
		{
			public int id;

			public string rarity;

			public double rate;

			public Rarity RarityValue()
			{
				return default(Rarity);
			}
		}

		public class RuneSlotAvailability
		{
			public int id;

			public string equipmentType;

			public string rarity;

			public double rateEachTryTime;

			public int tryCount;

			public EquipmentType EquipmentTypeValue()
			{
				return default(EquipmentType);
			}

			public Rarity RarityValue()
			{
				return default(Rarity);
			}
		}

		public class WeaponPassiveSkillStats
		{
			public string characterId;

			public string name;

			public int skillId;

			public int skillLevel;

			public string[] value;

			private WeaponPassiveSkillValue[] v;

			public WeaponPassiveSkillValue[] Values => null;

			public void Parse()
			{
			}

			public WeaponPassiveSkillName NameValue()
			{
				return default(WeaponPassiveSkillName);
			}

			public bool Find(WeaponPassiveSkillValueEnum wpsve, ref WeaponPassiveSkillValue result)
			{
				return false;
			}
		}

		public enum WeaponPassiveSkillName
		{
			Shockwave = 500,
			LastStand = 501,
			Blastwave = 502,
			DeadlyHeal = 503,
			AutoHeal = 504,
			InnateFighter = 505,
			Weakness = 506,
			MagicArt = 507,
			Rage = 508,
			MagicBarrier = 509,
			HardMuscle = 510,
			ReflectAttack = 511,
			Endurance = 512,
			LastHope = 513,
			NaturalHealing = 514,
			AllIn = 515,
			BestFriend = 516,
			Mobility = 517,
			LegendaryHunter = 518
		}

		public enum WeaponPassiveSkillValueEnum
		{
			rawPower = 0,
			hpThreshold = 1,
			successRate = 2,
			hpPercent = 3,
			scalePower = 4,
			cooldown = 5,
			duration = 6,
			stack = 7,
			duration2 = 8,
			scalePower2 = 9
		}

		public class WeaponPassiveSkillValue
		{
			private WeaponPassiveSkillValueEnum name;

			private double value;

			public WeaponPassiveSkillValueEnum Name => default(WeaponPassiveSkillValueEnum);

			public double Value => 0.0;

			public WeaponPassiveSkillValue(string raw)
			{
			}
		}

		public class WeaponPassiveSkill
		{
			public int id;

			public string characterId;

			public int grade;

			public string rarity;

			public string[] skillNames;

			public string[] skillLevelsBySkillNames;

			private SkillNameRate[] skillNameValues;

			private SkillLevelsBySkillName[] skillLevelsBySkillNamesValues;

			public SkillNameRate[] SkillNameValues => null;

			public SkillLevelsBySkillName[] SkillLevelsBySkillNamesValues => null;

			public void Parse()
			{
			}

			public Rarity RarityValue()
			{
				return default(Rarity);
			}
		}

		public class SkillNameRate
		{
			private WeaponPassiveSkillName name;

			private double rate;

			public WeaponPassiveSkillName Name => default(WeaponPassiveSkillName);

			public double Rate => 0.0;

			public SkillNameRate()
			{
			}

			public SkillNameRate(WeaponPassiveSkillName name, double rate)
			{
			}

			public SkillNameRate(string raw)
			{
			}
		}

		public class SkillLevelsBySkillName
		{
			private WeaponPassiveSkillName name;

			private SkillLevelRate[] skillLevelRates;

			public WeaponPassiveSkillName Name => default(WeaponPassiveSkillName);

			public SkillLevelRate[] SkillLevelRates => null;

			public SkillLevelsBySkillName()
			{
			}

			public SkillLevelsBySkillName(WeaponPassiveSkillName name, SkillLevelRate[] skillLevelRates)
			{
			}

			public SkillLevelsBySkillName(string raw)
			{
			}
		}

		public class WeaponPassiveSkillAvailability
		{
			public int id;

			public string rarity;

			public double rate;

			public Rarity RarityValue()
			{
				return default(Rarity);
			}
		}

		public Dictionary<string, MainStats> weaponMainStats;

		public Dictionary<string, MainStats> helmetArmorMainStats;

		public Dictionary<string, MainStats> chestArmorMainStats;

		public Dictionary<string, MainStats> pantArmorMainStats;

		public Dictionary<string, MainStats> accessoryMainStats;

		public Dictionary<string, BonusStatsType> bonusStatsTypes;

		public Dictionary<string, BonusStatsQuantity> bonusStatsQuantities;

		public Dictionary<string, BonusStatsValue> bonusStatsValues;

		public Dictionary<string, WeaponActiveSkill> weaponActiveSkills;

		public Dictionary<string, WeaponActiveSkillStats> weaponActiveSkillsStats;

		public Dictionary<string, RuneSlotAvailability> runeSlotAvailability;

		public Dictionary<string, WeaponPassiveSkillStats> weaponPassiveSkillsStats;

		public Dictionary<string, WeaponPassiveSkill> weaponPassiveSkills;

		public Dictionary<string, WeaponPassiveSkillAvailability> weaponPassivSkillAvailability;

		private Dictionary<string, WeaponActiveSkillStats> m_weaponActiveSkillStats;

		private Dictionary<string, WeaponActiveSkillStats> _maxLevelWeaponActiveSkillStats;

		public virtual void OnMapValue(string content)
		{
		}

		public bool FindWeaponMainStats(EquipmentTier grade, Rarity rarity, ref MainStats mainStats)
		{
			return false;
		}

		public bool FindHelmetMainStats(EquipmentTier grade, Rarity rarity, ref MainStats mainStats)
		{
			return false;
		}

		public bool FindChestMainStats(EquipmentTier grade, Rarity rarity, ref MainStats mainStats)
		{
			return false;
		}

		public bool FindPantMainStats(EquipmentTier grade, Rarity rarity, ref MainStats mainStats)
		{
			return false;
		}

		public bool FindAccessoryMainStats(EquipmentTier grade, Rarity rarity, ref MainStats mainStats)
		{
			return false;
		}

		public bool FindBonusStatsQuantity(Rarity rarity, ref BonusStatsQuantity bonusStatsQuantity)
		{
			return false;
		}

		public BonusStatsType[] FindBonusStatsTypes(EquipmentType equipmentType)
		{
			return null;
		}

		public bool FindBonusStatsValue(Rarity rarity, StatType statType, ref BonusStatsValue bonusStatsValue)
		{
			return false;
		}

		public bool FindWeaponPassiveSkillStats(int characterGroupId, int characterSubId, WeaponPassiveSkillName skillName, int skillLevel, ref WeaponPassiveSkillStats v)
		{
			return false;
		}

		public List<WeaponPassiveSkillName> listAllSkillNamesOfWeaponPassiveSkill(int charGroupId, int charSubId)
		{
			return null;
		}

		public bool FindWeaponActiveSkill(int characterGroupId, int characterSubId, int grade, Rarity rarity, ref WeaponActiveSkill weaponActiveSkill)
		{
			return false;
		}

		public bool FindWeaponPassiveSkill(int characterGroupId, int characterSubId, int grade, Rarity rarity, ref WeaponPassiveSkill weaponPassiveSkill)
		{
			return false;
		}

		public bool IsPassiveSkillAvailableForWeaponOf(Rarity rarity)
		{
			return false;
		}

		public bool FindRuneSlotCount(EquipmentType type, Rarity rarity, ref int count)
		{
			return false;
		}

		public bool FindMaxRuneSlotCount(EquipmentType type, Rarity rarity, ref int count)
		{
			return false;
		}

		private static string CharacterKey(int characterGroupId, int characterSubId)
		{
			return null;
		}

		public bool FindWeaponActiveSkillStats(int characterGroupId, int characterSubId, int skillId, int skillLevel, ref WeaponActiveSkillStats weaponActiveSkillStats)
		{
			return false;
		}

		public WeaponActiveSkillStats FindWeaponActiveSkillStats(EquipmentSkillInfo equipmentSkillInfo)
		{
			return null;
		}

		public WeaponActiveSkillStats FindMaxLevelWeaponActiveSkillStats(EquipmentSkillInfo equipmentSkillInfo)
		{
			return null;
		}

		protected bool FindMainStats(Dictionary<string, MainStats> data, EquipmentTier grade, Rarity rarity, ref MainStats mainStats)
		{
			return false;
		}

		private void CacheWeaponActiveSkillStats()
		{
		}
	}
}
