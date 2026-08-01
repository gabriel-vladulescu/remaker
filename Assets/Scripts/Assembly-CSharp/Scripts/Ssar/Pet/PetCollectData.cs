using System;
using Assets.Scripts.Model;
using CodeStage.AntiCheat.ObscuredTypes;
using LitJson;
using SSAR.Equipment.Enum;

namespace Scripts.Ssar.Pet
{
	[Serializable]
	public class PetCollectData : ICollectData, IItem
	{
		[JsonInclude]
		private PetEquippedEquipmentData petEquippedEquipmentData;

		public int collectID { get; set; }

		[JsonIgnore]
		public EnhanceItemType EnhanceItemType
		{
			get
			{
				return default(EnhanceItemType);
			}
			set
			{
			}
		}

		[JsonIgnore]
		public CollectType collectType
		{
			get
			{
				return default(CollectType);
			}
			set
			{
			}
		}

		public PetConfigId PetConfigId { get; set; }

		[JsonIgnore]
		public int enhanceLevel
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[JsonIgnore]
		public int awakenExp
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[JsonInclude]
		private ObscuredInt enhanceLevelObscuredInt { get; set; }

		[JsonInclude]
		private ObscuredInt awakenExpObscured { get; set; }

		public PetCollectData()
		{
		}

		public PetCollectData(PetConfigId petInfo, int collectId)
		{
		}

		public Rarity Rarity()
		{
			return default(Rarity);
		}

		public EquipmentTier Tier()
		{
			return default(EquipmentTier);
		}

		public PetEquippedEquipmentData GetPetEquippedEquipmentData()
		{
			return null;
		}
	}
}
