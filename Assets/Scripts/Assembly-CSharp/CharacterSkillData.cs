using System;
using System.Collections.Generic;
using LitJson;
using SSAR.SkillSystem.Model;

[Serializable]
public class CharacterSkillData
{
	public List<int> listActiveSkillEquipped;

	public Dictionary<string, ActiveSkillRuneData> activeSkillRuneData;

	public Dictionary<string, SignatureSkillLevelData> signatureSkillLevelDatas;

	public Dictionary<string, PassiveSkillLevelData> passiveSkillLevelDatas;

	[JsonInclude]
	private int controllerLayoutId;

	[JsonInclude]
	private bool isPvpSkillGuideNotified;

	public int pointBylevel;

	public int pointBonus;

	public void AddPointBonus(int pointBonus)
	{
	}

	public void AddSkillPointByLevel(int value)
	{
	}

	public int GetPointNormal()
	{
		return 0;
	}

	public void ResetListSkillEquipped()
	{
	}

	public CharacterSkillData Clone()
	{
		return null;
	}

	public void SetControllerLayoutId(int id)
	{
	}

	public int GetControllerLayoutId()
	{
		return 0;
	}

	public void NotifyPvpSkillGuide()
	{
	}

	public bool IsPvpSkillGuideNotified()
	{
		return false;
	}
}
