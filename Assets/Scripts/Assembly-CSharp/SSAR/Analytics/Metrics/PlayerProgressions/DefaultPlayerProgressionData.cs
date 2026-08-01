using Assets.Scripts.Config.Stats;
using SSAR.Equipment.Enum;
using SSAR.Equipment.Model;
using Scripts.Config;

namespace Ssar.Analytics.Metrics.PlayerProgressions
{
	public class DefaultPlayerProgressionData : PlayerProgressionData
	{
		private HeroData heroData;

		private BaseData baseData;

		private MainCharacterData mainCharacterData;

		private int nodeId;

		private DungeonConfig dungeonConfig;

		public DefaultPlayerProgressionData(MainCharacterData mainCharacterData, int nodeId, DungeonConfig dungeonConfig)
		{
		}

		public string Version()
		{
			return null;
		}

		public CharacterName CharacterName()
		{
			return default(CharacterName);
		}

		public string LevelString()
		{
			return null;
		}

		public int Level()
		{
			return 0;
		}

		public float PlayingTime()
		{
			return 0f;
		}

		public string NodeId()
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

		public float RealMoneySpent()
		{
			return 0f;
		}

		public string NodeValue()
		{
			return null;
		}

		public string HighestNodeValue()
		{
			return null;
		}

		public double Blood()
		{
			return 0.0;
		}

		public string Arena()
		{
			return null;
		}

		public int CurrentVideoPoint()
		{
			return 0;
		}

		public string WeaponRarity()
		{
			return null;
		}

		public int WeaponTier()
		{
			return 0;
		}

		public int WeaponEnhanceLevel()
		{
			return 0;
		}

		public int HelmetTier()
		{
			return 0;
		}

		public int HelmetEnhanceLevel()
		{
			return 0;
		}

		public int ChestTier()
		{
			return 0;
		}

		public int ChestEnhanceLevel()
		{
			return 0;
		}

		public int PantTier()
		{
			return 0;
		}

		public int PantEnhanceLevel()
		{
			return 0;
		}

		public int AmuletTier()
		{
			return 0;
		}

		public int AmuletEnhanceLevel()
		{
			return 0;
		}

		public int RingTier()
		{
			return 0;
		}

		public int RingEnhanceLevel()
		{
			return 0;
		}

		public int ItemGainCount()
		{
			return 0;
		}

		public string ItemGainRarity()
		{
			return null;
		}

		public float CurrentPlayingTime()
		{
			return 0f;
		}

		private string FindEquippingEquipmentRarity(EquipmentType equipmentType)
		{
			return null;
		}

		private int FindEquippingEquipmentTier(EquipmentType equipmentType)
		{
			return 0;
		}

		private int FindEquippingEquipmentEnhanceLevel(EquipmentType equipmentType)
		{
			return 0;
		}

		private bool FindEquippingEquipment(EquipmentType equipmentType, ref int collectedId)
		{
			return false;
		}

		private bool FindEquippingEquipment(int collectedId, ref EquipmentCollectData equipmentCollectData)
		{
			return false;
		}

		private bool FindEquippingEquipment(EquipmentType equipmentType, ref EquipmentCollectData equipmentCollectData)
		{
			return false;
		}
	}
}
