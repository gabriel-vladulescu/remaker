using System.Collections.Generic;
using SSAR.Entry.Model;
using SSAR.Equipment.Enum;
using SSAR.Equipment.Model;
using Scripts.Config;

namespace Assets.Scripts.Model
{
	public class EquipmentEnhanceLogic : IItemLogic
	{
		public override void LockItem(MainCharacterData mainCharacterData, IItem item)
		{
		}

		public override void UnLockItem(MainCharacterData mainCharacterData, IItem item)
		{
		}

		public override bool IsLocked(MainCharacterData mainCharacterData, IItem item)
		{
			return false;
		}

		public override int GetMaxEnhanceLevel(IItem item)
		{
			return 0;
		}

		public override int GetEnhanceEquipmentPrice(IItem item, int targetLevel)
		{
			return 0;
		}

		public override bool IsEquipped(MainCharacterData mainCharacterData, IItem item)
		{
			return false;
		}

		public override int GetSellPrice(IItem item)
		{
			return 0;
		}

		public override int GetSellPriceBeforeDivide(IItem item)
		{
			return 0;
		}

		public override string GetName(MainCharacterData mainCharacterData, IItem item)
		{
			return null;
		}

		public override int GetEquipmentAwakenMaterialExp(IItem item)
		{
			return 0;
		}

		public override float GetAwakenLvProgress(int exp, Rarity rarity, EquipmentTier tier)
		{
			return 0f;
		}

		public override int GetEquipmentAwakenSoulPricePerSlot(IItem item)
		{
			return 0;
		}

		public override int GetEquipmentAwakenExpLevelRequire(IItem item)
		{
			return 0;
		}

		public override float GetAwakenMainStatBonus(int awakenLevel)
		{
			return 0f;
		}

		public override List<EquipmentStat> GetMainStatsWithEnhance(IItem item, int enhanceLevel)
		{
			return null;
		}

		public override List<EquipmentStat> GetEquipmentSubStatsRaw(IItem item)
		{
			return null;
		}

		public override void DeleteItem(MainCharacterData mainCharacterData, IItem item)
		{
		}

		public override ComparerItemResult CompareItem(IItem left, IItem right)
		{
			return null;
		}

		public override IItem GetItem(MainCharacterData mainCharacterData, int collectId)
		{
			return null;
		}

		public override int GetAwakenMaxLevel()
		{
			return 0;
		}

		private ConfigManager ConfigManager()
		{
			return null;
		}
	}
}
