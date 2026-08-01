using System;
using System.Collections.Generic;
using Assets.Scripts.Model;
using CodeStage.AntiCheat.ObscuredTypes;
using LitJson;
using SSAR.Equipment.Enum;
using Ssar.Ancient.Model;
using Ssar.Rune.Model;

namespace SSAR.Equipment.Model
{
	[Serializable]
	public class EquipmentCollectData : ICollectData, IItem
	{
		public List<RuneSlot> runeSlots;

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

		public EquipmentConfigId configId { get; set; }

		public int reforgeCount { get; set; }

		public string ownerName { get; set; }

		public int usedCharge { get; set; }

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

		[JsonIgnore]
		public int ancientExp
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
		public bool HasRuneSlot => false;

		[JsonIgnore]
		public int ReforgeCount => 0;

		[JsonIgnore]
		public string OwnerName => null;

		[JsonIgnore]
		public int UsedCharge => 0;

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

		[JsonInclude]
		private ObscuredInt enhanceLevelObscuredInt { get; set; }

		[JsonInclude]
		private ObscuredInt awakenExpObscured { get; set; }

		[JsonInclude]
		private ObscuredInt ancientExpObscured { get; set; }

		public Rarity Rarity()
		{
			return default(Rarity);
		}

		public EquipmentTier Tier()
		{
			return default(EquipmentTier);
		}

		public EquipmentCollectData()
		{
		}

		public EquipmentCollectData(EquipmentConfigId configId, int collectId)
		{
		}

		public EquipmentConfigId GetEquipmentConfigId()
		{
			return null;
		}

		public void AddRuneSlot(ref int slotIndex, ref RuneSlot runeSlot)
		{
		}

		public void AddRuneSlot()
		{
		}

		public bool FindRuneSlot(int slotIndex, ref RuneSlot runeSlot)
		{
			return false;
		}

		public List<RuneSlot> FindRuneSlotsContain(RuneType runeType, RuneRarity runeRarity)
		{
			return null;
		}

		public List<RuneSlot> FindNotEmptyRuneSlots()
		{
			return null;
		}

		public bool HasNotEmptyRuneSlot()
		{
			return false;
		}

		public void ResetRuneSlots()
		{
		}

		public void AddReforgeCount()
		{
		}

		public void SetReforgeCount(int count)
		{
		}

		public void SetOwnerName(string name)
		{
		}

		public bool HasOwnerName()
		{
			return false;
		}

		public void AddUsedCharge()
		{
		}

		public void SetUsedCharge(int count)
		{
		}

		public List<ChargedAncientSkill> GetAncientSkillsWithCharge()
		{
			return null;
		}

		public void SetAwakenExp(int newExp)
		{
		}
	}
}
