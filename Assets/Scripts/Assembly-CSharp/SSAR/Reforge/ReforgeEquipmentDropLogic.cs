using Assets.Scripts.Ssar.Equipment;
using Ssar.Analytics.Metrics;
using Ssar.Reforge.Enum;

namespace Ssar.Reforge
{
	public class ReforgeEquipmentDropLogic : DefaultEquipmentDropLogic
	{
		private readonly CharacterId characterId;

		private readonly GradeDropConfig[] grades;

		public ReforgeEquipmentDropLogic(EquipmentDropConfig equipmentDropConfig, CharacterId characterId, GradeDropConfig[] grades, RarityDropConfig[] rarities)
			: base(null)
		{
		}

		public EquipmentConfigId Reforge(ReforgeType reforgeType, EquipmentConfigId baseEquipmentConfigId)
		{
			return null;
		}

		private void ReforgeSocket(EquipmentConfigId equipmentConfigId)
		{
		}

		private void ReforgeOptions(EquipmentConfigId equipmentConfigId)
		{
		}

		private void ReforgeOptionValues(EquipmentConfigId equipmentConfigId)
		{
		}

		private void ReforgeTier(EquipmentConfigId equipmentConfigId)
		{
		}

		private void ReforgeActiveSkill(EquipmentConfigId equipmentConfigId)
		{
		}

		private void ReforgeLevelActiveSkill(EquipmentConfigId equipmentConfigId)
		{
		}

		private EquipmentConfigId CloneEquipmentConfigId(EquipmentConfigId baseEquipmentConfigId)
		{
			return null;
		}
	}
}
