using Assets.Scripts.Ssar.Dungeon.GameModeLogic;
using SSAR.BattleSystem.Damage;

public class DamageData
{
	public DamageSource DamageSource;

	public BattleMode BattleMode;

	public float rawDamage { get; set; }

	public float critRate { get; set; }

	public float critDamageMul { get; set; }

	public float targetDef { get; set; }

	public float targetMagicResist { get; set; }

	public float targetDamageBlock { get; set; }

	public float targetMagicDamageBarrier { get; set; }

	public float targetBaseDamageReduction { get; set; }

	public float targetBlockChance { get; set; }

	public float targetMissChance { get; set; }

	public DamageType DamageType { get; set; }

	public ImmuneType[] ImmuneTypes { get; set; }

	public bool isHealer { get; set; }

	public bool isIgnoreDef { get; set; }

	public float targetDodgeChance { get; set; }

	public float skillCritRate { get; set; }

	public float skillCritDamageMul { get; set; }

	public float pvpDamageBonus { get; set; }

	public bool isCcImmune { get; set; }

	public DamageData(DamageSource damageSource, DamageType damageType, float rawDamage, ImmuneType[] immuneTypes, float critRate, float critDamageMul, float targetBaseDamageReduction, float targetDef, float targetMagicResist, float targetDamageBlock, float targetMagicBarrier, float targetDodgeChance, float targetBlockChance, float targetMissChance, bool isHealer, bool isIgnoreDef, float skillCritRate, float skillCritDmgMul, float pvpDamagegBonus, bool isCcImmune)
	{
	}

	public void SetBattleMode(BattleMode battleMode)
	{
	}
}
