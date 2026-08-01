using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
[CreateAssetMenu(menuName = "ScriptableOject/GameConfig")]
public class GameConfigPathScriptableObject : ScriptableObject
{
	[SerializeField]
	public List<string> configNames;

	[SerializeField]
	public List<ConfigRunMode> configRunModes;

	[SerializeField]
	public List<string> dataClass;

	private Dictionary<bool, List<string>> ListConfigInitWhenRun;

	private Dictionary<string, ConfigRunMode> m_ConfigRuneMode;

	public void AddFileConfig(string configName)
	{
	}

	public List<string> GetAllConfigs()
	{
		return null;
	}

	public string GetConfigNameWithIndex(int index)
	{
		return null;
	}

	public void SetDataModel(string configName, string dataModel)
	{
	}

	public ConfigRunMode GetRunMode(string configName)
	{
		return null;
	}

	public string GetDataClass(string configName)
	{
		return null;
	}

	public List<string> GetListConfigInitWhenRun(bool isEditor)
	{
		return null;
	}

	public List<string> GetListDownloadFromFirebase()
	{
		return null;
	}
}
