using System;
using UnityEngine;

[Serializable]
[CreateAssetMenu(menuName = "ScriptableOject/TestRaidTool")]
public class TestRaidTool : ScriptableObject
{
	public bool testMode;

	public int seasonId;

	public string mainCharacterData;

	public string[] companionData;

	public bool[] enableCompanion;

	public void Init()
	{
	}
}
