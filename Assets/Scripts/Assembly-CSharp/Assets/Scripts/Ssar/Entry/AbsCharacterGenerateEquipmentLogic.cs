using System.Collections.Generic;
using Assets.Scripts.Ssar.Equipment;
using SSAR.Equipment.Enum;
using SSAR.Equipment.Model;
using Scripts.Config;
using Ssar.Reforge;
using Ssar.Reforge.Enum;

namespace Assets.Scripts.Ssar.Entry
{
	public abstract class AbsCharacterGenerateEquipmentLogic
	{
		private class GradeDropPercentageToGradeDropConfigAdapter : GradeDropConfig
		{
			private GradeDropPercentage gdp;

			public GradeDropPercentageToGradeDropConfigAdapter(GradeDropPercentage gdp)
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
			private RarityDropPercentage rdp;

			public RarityDropPercentageToRarityDropConfigAdapter(RarityDropPercentage rdp)
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
			private TypeDropPercentage tdp;

			public TypeDropPercentageToTypeDropConfigAdapter(TypeDropPercentage tdp)
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

		private EquipmentDropLogic edl;

		private ReforgeEquipmentDropLogic reforgeLogic;

		private const int REFORGE_RANDOM_ID = 7777771;

		public EquipmentConfigId Generate(int randomEquipmentId, List<VisualId> visualIdPrefer = null, List<int> visualIdIgnore = null)
		{
			return null;
		}

		public EquipmentConfigId Generate(TypeDropPercentage[] typeDropPercentages, RarityDropPercentage[] rarityDropPercentages, GradeDropPercentage[] gradeDropPercentages, string visualCategory)
		{
			return null;
		}

		public EquipmentConfigId CraftingRegerate(int craftRandomId, TypeDropPercentage[] typeDropPercentages, RarityDropPercentage[] rarityDropPercentages, int visualID, string visualCategory)
		{
			return null;
		}

		public EquipmentConfigId ReforgeGenerate(ReforgeType reforgeType, EquipmentConfigId baseEquipmentConfigId)
		{
			return null;
		}

		public EquipmentDropConfig GetEquipmentDropConfig()
		{
			return null;
		}

		public WeaponActiveSkillConfig GetWeaponActiveSkillConfig(EquipmentCollectData equipmentCollectData)
		{
			return null;
		}

		public WeaponPassiveSkillConfig GetWeaponPassiveSkillConfig(EquipmentCollectData equipmentCollectData)
		{
			return null;
		}

		protected abstract int CharacterGroupId();

		protected abstract int CharacterSubId();

		public abstract JsonRandomEquipmentConfig RandomEquipmentConfig();

		public abstract JsonEquipmentDropConfig EquipmentDropConfig();

		public abstract JsonCosmeticEquipmentDropConfig CosmeticDropConfig();

		public abstract AncientEquipmentConfig AncientEquipmentConfig();

		protected abstract EquipmentVisualConfig EquipmentVisualConfig();

		protected abstract GameConfigConstant GameConfigConstant();

		private static GradeDropConfig[] Convert(GradeDropPercentage[] list)
		{
			return null;
		}

		private static RarityDropConfig[] Convert(RarityDropPercentage[] list)
		{
			return null;
		}

		private static TypeDropConfig[] Convert(TypeDropPercentage[] list)
		{
			return null;
		}
	}
}
