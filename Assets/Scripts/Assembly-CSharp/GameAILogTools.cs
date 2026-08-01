using System;
using UnityEngine;

[Serializable]
[CreateAssetMenu(menuName = "ScriptableOject/GameAILog")]
public class GameAILogTools : ScriptableObject
{
	public bool enable;

	public bool AI_enableLog;

	public bool AI_logChangeState;

	public bool AI_logCooldown;

	public bool AI_logRecoveryTime;

	public bool AI_logTrigger;

	public bool AI_logPrepare;

	public bool AI_logDamgeTaken;

	public bool AI_logCurrentState;

	public bool AI_logBuffDuration;
}
