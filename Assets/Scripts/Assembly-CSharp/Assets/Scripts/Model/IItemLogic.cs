using System.Collections.Generic;
using SSAR.Entry.Model;
using SSAR.Equipment.Enum;
using SSAR.Equipment.Model;

namespace Assets.Scripts.Model
{
	public abstract class IItemLogic
	{
		public abstract void LockItem(MainCharacterData mainCharacterData, IItem item);

		public abstract void UnLockItem(MainCharacterData mainCharacterData, IItem item);

		public abstract bool IsLocked(MainCharacterData mainCharacterData, IItem item);

		public abstract int GetMaxEnhanceLevel(IItem item);

		public abstract int GetEnhanceEquipmentPrice(IItem item, int targetLevel);

		public abstract bool IsEquipped(MainCharacterData mainCharacterData, IItem item);

		public abstract int GetSellPrice(IItem item);

		public abstract int GetSellPriceBeforeDivide(IItem item);

		public abstract string GetName(MainCharacterData mainCharacterData, IItem item);

		public abstract int GetEquipmentAwakenMaterialExp(IItem item);

		public abstract float GetAwakenLvProgress(int exp, Rarity rarity, EquipmentTier tier);

		public abstract int GetEquipmentAwakenSoulPricePerSlot(IItem item);

		public abstract int GetEquipmentAwakenExpLevelRequire(IItem item);

		public abstract float GetAwakenMainStatBonus(int awakenLevel);

		public abstract List<EquipmentStat> GetMainStatsWithEnhance(IItem item, int enhanceLevel);

		public abstract List<EquipmentStat> GetEquipmentSubStatsRaw(IItem item);

		public abstract void DeleteItem(MainCharacterData mainCharacterData, IItem item);

		public abstract ComparerItemResult CompareItem(IItem left, IItem right);

		public abstract IItem GetItem(MainCharacterData mainCharacterData, int collectId);

		public abstract int GetAwakenMaxLevel();
	}
}
