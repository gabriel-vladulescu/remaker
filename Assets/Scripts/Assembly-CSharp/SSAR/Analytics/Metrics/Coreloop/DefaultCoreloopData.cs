using SSAR.Equipment.Enum;
using SSAR.Equipment.Model;
using Scripts.Config;

namespace Ssar.Analytics.Metrics.Coreloop
{
	public class DefaultCoreloopData : CoreloopData
	{
		private BaseData baseData;

		private MainCharacterData mainCharacterData;

		private DungeonConfig dungeonConfig;

		public DefaultCoreloopData(BaseData baseData, MainCharacterData mainCharacterData, DungeonConfig dungeonConfig)
		{
		}

		public string Version()
		{
			return null;
		}

		public string CharacterId()
		{
			return null;
		}

		public string LevelString()
		{
			return null;
		}

		public int Level()
		{
			return 0;
		}

		public int PlayingTime()
		{
			return 0;
		}

		public string HighestRankId()
		{
			return null;
		}

		public CharacterName CharacterName()
		{
			return default(CharacterName);
		}

		public string HighestNodeId()
		{
			return null;
		}

		public string HighestNodeValue()
		{
			return null;
		}

		public int CurrentGold()
		{
			return 0;
		}

		public int CurrentCrystal()
		{
			return 0;
		}

		private string GetEquipmentIdAndMainStat(EquipmentType equipmentType, EquipmentConfig equipmentConfig, AwakenEquipmentConfig awakenEquipmentConfig, SlotType slotType = SlotType.DEFAULT)
		{
			return null;
		}

		public string CurrentWeapon()
		{
			return null;
		}

		public string CurrentArmor()
		{
			return null;
		}

		public string CurrentAccessory()
		{
			return null;
		}

		public string CurrentCostume()
		{
			return null;
		}

		public string CurrentAncient()
		{
			return null;
		}
	}
}
