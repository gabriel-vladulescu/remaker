using SSAR.Equipment.Enum;
using Scripts.Config;

public class EquipmentStatData : AbsStats
{
	public StatType statsType { get; set; }

	public double HP { get; set; }

	public double Def { get; set; }

	public double Atk { get; set; }

	public double CritChance { get; set; }

	public double CritDamage { get; set; }

	public double MagicResist { get; set; }

	public double DamageReduction { get; set; }

	public double DamageAmplification { get; set; }

	public double DamageBlockPerAttack { get; set; }

	public double MagicDamageBarrier { get; set; }

	public double BonusItemDropRate { get; set; }

	public double BonusExpGain { get; set; }

	public double BonusSoulGain { get; set; }

	public double AtkPercent { get; set; }

	public double DefPercent { get; set; }

	public double HpPercent { get; set; }

	public double BonusDamageAgainstBoss { get; set; }

	public double DodgeChance { get; set; }

	public double BonusHpPerHit { get; set; }

	public double BlockChance { get; set; }

	public double BossDamageReduction { get; set; }

	public double HpRecoveryPerSecond { get; set; }

	public double LifeSteal { get; set; }

	public double MissChance { get; set; }

	public double BonusAttackSpeed { get; set; }

	public double BonusMovSpd { get; set; }

	public double skillCritChance { get; set; }

	public double skillCritDamage { get; set; }

	public double bonusDamagePvp { get; set; }

	public EquipmentStatData FakeData()
	{
		return null;
	}

	protected override void Properties2Map()
	{
	}
}
