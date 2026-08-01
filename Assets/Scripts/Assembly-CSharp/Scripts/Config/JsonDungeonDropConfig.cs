using System.Collections.Generic;
using Assets.Scripts.Config;
using SSAR.Equipment.Enum;

namespace Scripts.Config
{
	public class JsonDungeonDropConfig : IConfig
	{
		public class DungeonDrop
		{
			public int dungeonId;

			public int maxDropCount;

			public string[] grades;

			public string[] rarities;

			public string[] types;

			public double dropPercentage;

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

			private float percentage;

			public string RawValue => null;

			public EquipmentTier Grade => default(EquipmentTier);

			public float Percentage => 0f;

			public GradeDropPercentage(string rawValue)
			{
			}
		}

		public class RarityDropPercentage
		{
			private string rawValue;

			private Rarity rarity;

			private float percentage;

			public string RawValue => null;

			public Rarity Rarity => default(Rarity);

			public float Percentage => 0f;

			public RarityDropPercentage(string rawValue)
			{
			}
		}

		public class TypeDropPercentage
		{
			private string rawValue;

			private EquipmentType type;

			private float percentage;

			public string RawValue => null;

			public EquipmentType Type => default(EquipmentType);

			public float Percentage => 0f;

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

			public int min;

			public int max;

			public Rarity Rarity => default(Rarity);

			public EquipmentTier Grade => default(EquipmentTier);
		}

		public class BonusStatsType
		{
			public int id;

			public string equipmentType;

			public string statsType;

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

			public int grade;

			public string statsType;

			public int[] value;

			public EquipmentTier Grade => default(EquipmentTier);

			public StatType StatsType => default(StatType);
		}

		public Dictionary<string, DungeonDrop> dungeon_1_3_NORMAL;

		public Dictionary<string, DungeonDrop> dungeon_1_3_HARD;

		public Dictionary<string, DungeonDrop> dungeon_1_3_HELL;

		public Dictionary<string, DungeonDrop> dungeon_1_3_INSANE;

		private Dictionary<string, DungeonDrop> dungeonDrops;

		public void OnMapValue(string content)
		{
		}

		public bool FindDungeonDrop(int dungeonId, ref DungeonDrop dungeonDrop)
		{
			return false;
		}

		private void CheckTotalRateOfTypesOfEachDungeonDropEquals100()
		{
		}

		private void CheckTotalRateOfRaritiesOfEachDungeonDropEquals100()
		{
		}

		private void CheckTotalRateOfGradesOfEachDungeonDropEquals100()
		{
		}

		private void AddToDict(Dictionary<string, DungeonDrop> d, ref Dictionary<string, DungeonDrop> ret)
		{
		}
	}
}
