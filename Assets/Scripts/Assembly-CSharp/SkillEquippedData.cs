using System.Collections.Generic;
using SSAR.SkillSystem.Model;
using SSAR.SkillSystem.Utils;

public class SkillEquippedData
{
	public List<int> listActiveSkillEquipped;

	public Dictionary<string, ActiveSkillRuneData> activeSkillRuneData;

	public Dictionary<string, SignatureSkillLevelData> signatureSkillLevelDatas;

	public Dictionary<string, PassiveSkillLevelData> passiveSkillLevelDatas;

	public void TransferSkillData()
	{
	}

	public void EquipSkill(int skillId, int index)
	{
	}

	public void Reset()
	{
	}

	public void SetRuneLevel(int skillId, RuneType runeType, int level)
	{
	}

	public int GetRuneLevel(int skillId, RuneType runeType)
	{
		return 0;
	}

	public int GetSignatureSkillLevel(int skillId)
	{
		return 0;
	}

	public void SetSignatureSkillLevel(int skillId, int level)
	{
	}

	public int GetPassiveSkillLevel(int skillId)
	{
		return 0;
	}

	public bool IsPassiveSkillLearnt(int skillId)
	{
		return false;
	}

	public void SetPassiveSkillLevel(int skillId, int level)
	{
	}

	public void InvestToRuneOfSkill(int skillId, RuneType runeType, int value)
	{
	}

	public void DivestRuneOfSkill(int skillId, RuneType runeType)
	{
	}

	public void InvestSignatureSkill(int skillId, int value)
	{
	}

	public void DivestSignatueSkill(int skillId)
	{
	}

	public void InvestPassiveSkill(int skillId, int value)
	{
	}

	public void DivestPassiveSKill(int skillId)
	{
	}

	public ActiveSkillRuneData GetActiveSkillRuneData(int skillId)
	{
		return null;
	}

	public int GetPointInvested()
	{
		return 0;
	}

	public SignatureSkillLevelData GetSignatureSkillLevelData(int skillId)
	{
		return null;
	}

	public PassiveSkillLevelData GetPassiveSkillLevelData(int skillId)
	{
		return null;
	}

	public List<int> GetListActiveSkillEquipped()
	{
		return null;
	}

	public Dictionary<string, ActiveSkillRuneData> GetActiveSkillRuneDatas()
	{
		return null;
	}

	public Dictionary<string, SignatureSkillLevelData> GetSignatureSkillLevelDatas()
	{
		return null;
	}

	public Dictionary<string, PassiveSkillLevelData> GetPassiveSkillLevelDatas()
	{
		return null;
	}

	public SkillEquippedData Clone()
	{
		return null;
	}

	public void UpdateData(SkillEquippedData characterSkillData)
	{
	}

	public bool HasModifyData(SkillEquippedData characterSkillData, List<int> allActiveSkillId, List<int> AllSignatureSkillId, List<int> AllPassiveSkillId)
	{
		return false;
	}

	public void ResetListSkillEquipped()
	{
	}
}
