using System;
using System.Collections.Generic;
using SSAR.BattleSystem.Camera;
using UnityEngine;

[Serializable]
[CreateAssetMenu(menuName = "ScriptableOject/ShakeCameraConfig")]
public class ShakeCameraConfig : ScriptableObject
{
	public List<ShakeCameraData> dict;

	public List<ShakeCameraConfigId> names;

	public ShakeCameraData AddConfig(ShakeCameraConfigId id)
	{
		return null;
	}

	public ShakeCameraData GetConfig(ShakeCameraConfigId id)
	{
		return null;
	}

	public List<ShakeCameraData> GetCameraConfigs()
	{
		return null;
	}
}
