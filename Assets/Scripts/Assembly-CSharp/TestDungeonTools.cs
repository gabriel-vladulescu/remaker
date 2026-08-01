using System;
using System.Collections.Generic;
using SSAR.SkillSystem.Utils;
using UnityEngine;

[Serializable]
[CreateAssetMenu(menuName = "ScriptableOject/TestDungeonTools")]
public class TestDungeonTools : ScriptableObject
{
	public int groupdId;

	public int subId;

	public int level;

	public int helmetStat;

	public int armorStat;

	public int pantStat;

	public int weaponStat;

	public int amuletStat;

	public int ringStat;

	public int petGroupId;

	public int petSubId;

	public int ancientId1;

	public int ancientLv1;

	public int ancientId2;

	public int ancientLv2;

	public List<TestDungeonToolsActiveSkilLData> ActiveSkilLDatas;

	public List<TestDungeonToolSignatureSkillData> SignatureSkillDatas;

	public List<TestDungeonToolPassiveSkillData> PassiveSkillDatas;

	public int dungeonId;

	public int GetActiveSkillRuneLevel(int groupId, int subId, int skillId, RuneType runeType)
	{
		return 0;
	}

	public void SetActiveSkillRuneLevel(int groupId, int subId, int skillId, RuneType runeType, int level)
	{
	}

	public void SetActiveSkillOrder(int groupId, int subId, int skillId, int order)
	{
	}

	public int GetActiveSkillOrder(int groupId, int subId, int skillId)
	{
		return 0;
	}

	public int GetSignatureSkillLevel(int groupId, int subId, int skillId)
	{
		return 0;
	}

	public void SetSignatureSkillLevel(int groupId, int subId, int skillId, int level)
	{
	}

	public int GetPassiveSkillLevel(int groupId, int subId, int skillId)
	{
		return 0;
	}

	public void SetPassiveSkillLevel(int groupId, int subId, int skillId, int level)
	{
	}

	public TestDungeonToolsActiveSkilLData GetTestDungeonToolsActiveSkilLData(int groupId, int subId, int skillId)
	{
		return null;
	}

	public TestDungeonToolSignatureSkillData GetTestDungeonToolsSignatureSkilLData(int groupId, int subId, int skillId)
	{
		return null;
	}

	public TestDungeonToolPassiveSkillData GetTestDungeonToolPassiveSkilLData(int groupId, int subId, int skillId)
	{
		return null;
	}
}
