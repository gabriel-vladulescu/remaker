using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
[CreateAssetMenu(menuName = "ScriptableOject/TutorialTools")]
public class TutorialConfig : ScriptableObject
{
	public bool enableCheat;

	public float bossHpThreshold1;

	public float bossHpThreshold2;

	public float delayDialog;

	public float delayAutoNextDialog;

	public float dungeonStoryFadeInDuration;

	public float dungeonStoryFadeInHoldDuration;

	public float dungeonStoryFadeOutDuration;

	public List<int> listTutorial;

	public List<bool> isComplete;

	public float delaySpawnBossAfterClearStage;

	public float spiderHpThreshold;

	public float delayShowDialogAfterSpiderAppear;

	public float bossHpBuff;

	public float chacterHpBuff;

	public float bossAppearFadeInDuration;

	public float bossAppearFadeOutDuration;

	public float scaleTime;

	public float slowMotionDuration;

	public float blaskMaskAlpha;

	public int numOfMonsterRequireToSpawnBoss;

	public float delayShowSkill23;

	public int cosmeticSetId;

	public int attackOverride;

	public int wingVisualId;

	public float treantHpBuff;

	public float spierHpEnableUltimate;
}
