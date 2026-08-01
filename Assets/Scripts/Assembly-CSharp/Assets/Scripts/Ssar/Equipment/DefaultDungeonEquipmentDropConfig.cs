using SSAR.Equipment.Enum;
using Scripts.Config;

namespace Assets.Scripts.Ssar.Equipment
{
	public class DefaultDungeonEquipmentDropConfig : DungeonEquipmentDropConfig
	{
		private class DefaultDungeonDropConfig : DungeonDropConfig
		{
			private JsonDungeonDropConfig.DungeonDrop dungeonDrop;

			public DefaultDungeonDropConfig(JsonDungeonDropConfig.DungeonDrop dungeonDrop)
			{
			}

			public int MaxDropCount()
			{
				return 0;
			}

			public GradeDropConfig[] ShowGradesDropConfig()
			{
				return null;
			}

			public RarityDropConfig[] ShowRaritiesDropConfig()
			{
				return null;
			}

			public TypeDropConfig[] ShowTypesDropConfig()
			{
				return null;
			}

			public float DropPercentage()
			{
				return 0f;
			}
		}

		private class GradeDropPercentageToGradeDropConfigAdapter : GradeDropConfig
		{
			private JsonDungeonDropConfig.GradeDropPercentage gradeDropPercentage;

			public GradeDropPercentageToGradeDropConfigAdapter(JsonDungeonDropConfig.GradeDropPercentage gradeDropPercentage)
			{
			}

			public EquipmentTier Grade()
			{
				return default(EquipmentTier);
			}

			public float DropRate()
			{
				return 0f;
			}
		}

		private class RarityDropPercentageToRarityDropConfigAdapter : RarityDropConfig
		{
			private JsonDungeonDropConfig.RarityDropPercentage rarityDropPercentage;

			public RarityDropPercentageToRarityDropConfigAdapter(JsonDungeonDropConfig.RarityDropPercentage rarityDropPercentage)
			{
			}

			public Rarity Rarity()
			{
				return default(Rarity);
			}

			public float DropRate()
			{
				return 0f;
			}
		}

		private class TypeDropPercentageToTypeDropConfigAdapter : TypeDropConfig
		{
			private JsonDungeonDropConfig.TypeDropPercentage typeDropPercentage;

			public TypeDropPercentageToTypeDropConfigAdapter(JsonDungeonDropConfig.TypeDropPercentage typeDropPercentage)
			{
			}

			public EquipmentType Type()
			{
				return default(EquipmentType);
			}

			public float DropRate()
			{
				return 0f;
			}
		}

		private JsonDungeonDropConfig rawJsonDungeonDropConfig;

		public DefaultDungeonEquipmentDropConfig(JsonDungeonDropConfig rawJsonDungeonDropConfig)
		{
		}

		public bool FindDungeonDropConfig(int dungeonId, ref DungeonDropConfig dungeonDropConfig)
		{
			return false;
		}
	}
}
