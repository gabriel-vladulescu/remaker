using System;
using System.Collections.Generic;
using SSAR.BattleSystem.Effect;
using UnityEngine;

[Serializable]
[CreateAssetMenu(menuName = "ScriptableOject/HackToolsForEffector")]
public class HackToolsForEffector : ScriptableObject
{
	public bool overrideDamage;

	public bool overrideCritRate;

	public bool overrideHp;

	public bool overrideDodgeChance;

	public bool overrideDmgAgainstBoss;

	public bool overrideLifeOnHit;

	public bool overrideBlockChance;

	public bool overrideBossDamageReduction;

	public bool overrideLifePerSecond;

	public bool overrideLifeSteal;

	public bool overrideMissChance;

	public bool overrideAttackSpd;

	public bool overrideBonusMovSpd;

	public bool overrideSkillCritRate;

	public bool overrideSkillCritDmg;

	public bool overrideAutoPlay;

	public bool overrideMaxPotion;

	public bool overridePotion;

	public float damage;

	public float critRate;

	public float maxHp;

	public float dodgeChance;

	public float dmgAgainstBoss;

	public float lifeOnHit;

	public float blockChance;

	public float bossDamageReduction;

	public float lifePerSecond;

	public float lifeSteal;

	public float missChance;

	public float bonusAttackSpd;

	public float bonusMovSpd;

	public float skillCritRate;

	public float skillCritDMg;

	public int maxPotion;

	public int potion;

	public bool skillNoCooldown;

	public bool playerCorpse;

	public bool autoPlay;

	public bool disableEenemyAI;

	public bool disableArenaRune;

	public bool disableBossCameraEffect;

	public bool disableArenaStartEffect;

	public List<EffectEditorInfo> EffectEditorInfos;

	public EffectEditorInfo GetEffectEditorInfo(EffectPathIndex index)
	{
		return null;
	}

	public void UpdateEffectEditorInfo(EffectPathIndex index, string path, StatusEffectLayer pos, int durationInFrames, int startAtFrame, List<CharOffset> charOffsets, List<JointInfo> jointInfos, List<CharScale> scaleInfos)
	{
	}

	public string GetEffectPath(EffectPathIndex index)
	{
		return null;
	}
}
