using System;
using SSAR.WorldMap.Enum;
using UnityEngine;

[Serializable]
[CreateAssetMenu(menuName = "ScriptableOject/DevTools")]
public class DevTools : ScriptableObject
{
	public bool enableTimeOffset;

	public int offsetDays;

	public int offsetHours;

	public int offsetMinutes;

	public int offsetSeconds;

	public bool overrideSceneStart;

	public string sceneStart;

	public bool disableBundleNotify;

	public bool overrideLevelInit;

	public bool overrideAllNodeStarsInit;

	public int levelInit;

	public NodeStatus allNodeStarsInit;

	public bool disablePopupNotify;

	public bool disableLoadConfigDynamic;

	public string pvpLeftData;

	public string pvpRightData;

	public bool overrideSeasonId;

	public int seasonId;

	public string environment;

	public string database;

	public string cloudFunction;

	public bool disableRemoteFirebaseConfig;

	public bool disableCachedFirebaseConfig;
}
