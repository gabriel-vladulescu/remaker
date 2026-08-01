using System;
using System.Collections.Generic;
using LitJson;
using SSAR.Equipment.Enum;
using SSAR.Equipment.Model;
using Ssar.Ancient.Model;

[Serializable]
public class EquipmentConfigId
{
	public string skillId;

	public int skillLevel;

	public int runeSlotCount;

	public List<PassiveSkill> passiveSkills;

	public List<ActiveSkill> activeSkills;

	public List<AncientSkill> ancientSkills;

	public int collectId;

	public EquipmentStat[] Stats;

	public EquipmentType EquipmentType { get; set; }

	public EquipmentTier Tier { get; set; }

	public Rarity Rarity { get; set; }

	public EquipmentStat MainStat { get; set; }

	public int visualId { get; set; }

	public string visualCategory { get; set; }

	[JsonIgnore]
	public string SkillId
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[JsonIgnore]
	public int SkillLevel
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
	public int RuneSlotCount
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
	public List<PassiveSkill> PassiveSkills => null;

	[JsonIgnore]
	public List<AncientSkill> AncientSkills => null;

	[JsonIgnore]
	public int AncientSkillId => 0;

	public void AddActiveSkill(string skillId, int skillLevel)
	{
	}

	public EquipmentConfigId FakeData(EquipmentType equipmentType, EquipmentTier tier, Rarity rarity, EquipmentStat mainStat, EquipmentStat[] stats)
	{
		return null;
	}

	public void SetVisualId(int visualId)
	{
	}

	public void SetVisualCategory(string visualCategory)
	{
	}

	public string GetVisualCategory()
	{
		return null;
	}

	public EquipmentSkillInfo GetActiveSkillInfo()
	{
		return null;
	}

	public List<EquipmentSkillInfo> GetAllActiveSkillsInfo()
	{
		return null;
	}

	public EquipmentSkillInfo GetPassiveSkillInfo()
	{
		return null;
	}

	public void AddPassiveSkill(string name, int level)
	{
	}

	public void SetCollectId(int collectId)
	{
	}

	public bool AdjustActiveSkillLevel(int index, int level)
	{
		return false;
	}

	public bool AdjustPassiveSkillLevel(int index, int level)
	{
		return false;
	}

	public void ClearAllActiveSkills()
	{
	}

	public void ClearAllPassiveSkills()
	{
	}

	public override string ToString()
	{
		return null;
	}

	private bool IsFirstActiveSkillReadyToUse()
	{
		return false;
	}

	public void AddAncientSkill(int id, int level)
	{
	}

	public void ClearAncientSkills()
	{
	}

	public List<EquipmentSkillInfo> GetAllAncientSkillInfos()
	{
		return null;
	}

	public void SetAncientSkillId(int id)
	{
	}
}
