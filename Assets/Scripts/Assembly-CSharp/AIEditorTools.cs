using System;
using System.Collections.Generic;
using SSAR.BattleSystem.AI;
using Ssar.BattleSystem.AISystem.Condition;
using UnityEngine;

[Serializable]
[CreateAssetMenu(menuName = "ScriptableOject/AITools")]
public class AIEditorTools : ScriptableObject
{
	public float leaderHpLossThreshold;

	public float leaderKnockbackTime;

	public float pvpMeleeHpLostThreshold;

	public float pvpMeleeKnockBackTime;

	public float pvpRangeHpLostThreshold;

	public float pvpRangeKnockbackTime;

	public bool overrideMonsterSpawn;

	public int maxSpawn;

	public int hp;

	public int def;

	public List<string> listMob;

	public List<ActionConfig> dic;

	public List<NewAIDelayEnableConfig> delayEnable;

	public List<NewAIAdvanceConfig> AdvanceConfigs;

	[SerializeField]
	public List<ActionNameToClassConfig> ActionNameToClassConfigs;

	[SerializeField]
	public List<ConditionTypeToClassConfig> ConditionTypeToClassConfigs;

	public List<ActionConfig> GetActionConfigs(string mobType)
	{
		return null;
	}

	public NewAIDelayEnableConfig GetDelayEnableConfig(string mobType)
	{
		return null;
	}

	public NewAIAdvanceConfig GetAdvanceConfig(string mobType)
	{
		return null;
	}

	public List<string> GetListActionCanAdd(string mobType)
	{
		return null;
	}

	public ActionConfig AddAction(string mobType, ActionName actionName, AIFlag flag = AIFlag.ALL)
	{
		return null;
	}

	public void AddAction(ActionConfig actionConfig)
	{
	}

	public void RemoveAction(string mobType, ActionConfig actionConfig)
	{
	}

	public void GetListActionAndId(string mobType, out List<ActionName> names, out List<int> actionId)
	{
		names = null;
		actionId = null;
	}

	public ActionConfig GetActionConfigById(string mobType, int actionId)
	{
		return null;
	}

	public void AddOverrideMonster(string behaviour)
	{
	}

	public void RemoveMonster(string behaviour)
	{
	}

	public void AddActionNameToClassConfig(ActionName actionName)
	{
	}

	public ActionNameToClassConfig GetActionNameToClassConfig(ActionName actionName)
	{
		return null;
	}

	public void AddConditionTypeToClassConfig(ConditionType conditionType)
	{
	}

	public ConditionTypeToClassConfig GetConditionTypeToClassConfig(ConditionType conditionType)
	{
		return null;
	}
}
