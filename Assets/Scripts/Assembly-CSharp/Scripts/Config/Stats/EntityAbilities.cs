using System;
using System.Collections.Generic;
using Assets.Scripts.Utils;

namespace Scripts.Config.Stats
{
	public class EntityAbilities : AbsStats, ICloneable
	{
		public Dictionary<string, object> valueWithAttributeName;

		public double HP { get; set; }

		public double Def { get; set; }

		public double Atk { get; set; }

		public double CritChance { get; set; }

		public double SkillCritChance { get; set; }

		public double CritDamage { get; set; }

		public double SkillCritDamage { get; set; }

		public double MagicResist { get; set; }

		public double DamageReduction { get; set; }

		public double DamageAmplification { get; set; }

		public double DamageBlockPerAttack { get; set; }

		public double MagicDamageBarrier { get; set; }

		public double BonusItemDropRate { get; set; }

		public double BonusExpGain { get; set; }

		public double BonusSoulGain { get; set; }

		public double KnockbackWeight { get; set; }

		public double KnockdownWeight { get; set; }

		public double BonusAttack { get; set; }

		public double BonusCritDamage { get; set; }

		public double BonusCritChance { get; set; }

		public double BonusSkillDamage { get; set; }

		public double BonusDamageBlockPerAttack { get; set; }

		public double BonusDef { get; set; }

		public double BonusMagicResist { get; set; }

		public double BonusHpPerHit { get; set; }

		public double BonusHp { get; set; }

		public double BonusHpPercent { get; set; }

		public double BonusDamageAgainstBoss { get; set; }

		public double BonusDamagePvP { get; set; }

		public double BonusAttackSpeed { get; set; }

		public double BonusCooldownReduction { get; set; }

		public double BonusAttackPercent { get; set; }

		public double BonusDefPercent { get; set; }

		public double BlockChance { get; set; }

		public double HpRecoveryPerSecond { get; set; }

		public double LifeSteal { get; set; }

		public double MissChance { get; set; }

		public double BonusMovSpd { get; set; }

		public double DodgeChance { get; set; }

		public double BossDamageReduction { get; set; }

		public double AtkSpd { get; set; }

		public double MovSpd { get; set; }

		public double BonusHpPercentPerKill { get; set; }

		public double FinalHpPercentPerKill()
		{
			return 0.0;
		}

		public double FinalAttack()
		{
			return 0.0;
		}

		public double FinalCritDamage()
		{
			return 0.0;
		}

		public virtual double FinalCritChance()
		{
			return 0.0;
		}

		public double FinalSkillDamage()
		{
			return 0.0;
		}

		public double FinalDamageBlockPerAttack()
		{
			return 0.0;
		}

		public double FinalDef()
		{
			return 0.0;
		}

		public virtual double FinalMagicResist()
		{
			return 0.0;
		}

		public double FinalHpPerHit()
		{
			return 0.0;
		}

		public double FinalHp()
		{
			return 0.0;
		}

		public double FinalDamageAgainstBoss()
		{
			return 0.0;
		}

		public virtual double FinalAttackSpeed()
		{
			return 0.0;
		}

		public virtual double FinalCooldownReduction()
		{
			return 0.0;
		}

		public double FinalDodgeChance()
		{
			return 0.0;
		}

		public double FinalBlockChance()
		{
			return 0.0;
		}

		public double FinalBossDamageReduction()
		{
			return 0.0;
		}

		public double FinalAutoRecoveryHpPerSecond()
		{
			return 0.0;
		}

		public double FinalLifeSteal()
		{
			return 0.0;
		}

		public double FinalMissChance()
		{
			return 0.0;
		}

		public virtual double FinalBonusMovSpd()
		{
			return 0.0;
		}

		public virtual double FinalDamageReduction()
		{
			return 0.0;
		}

		public double FinalMagicDamageBarrier()
		{
			return 0.0;
		}

		public double FinalBonusItemDropRate()
		{
			return 0.0;
		}

		public double FinalBonusExpGain()
		{
			return 0.0;
		}

		public double FinalBonusSoulGain()
		{
			return 0.0;
		}

		public double FinalSkilLCritChance()
		{
			return 0.0;
		}

		public double FinalSkillCritDamage()
		{
			return 0.0;
		}

		public double FinalBonusPvpDamage()
		{
			return 0.0;
		}

		public void TransferData(EntityAbilities a)
		{
		}

		public void SnapDictData(EntityAbilities abilities)
		{
		}

		protected override void Properties2Map()
		{
		}

		protected override void AddTransferData(string attributeName, TransferType type, object value, bool isMain = false)
		{
		}

		public void Map2Properties()
		{
		}

		public string SetStringValue(string origin, string value)
		{
			return null;
		}

		public object Clone()
		{
			return null;
		}
	}
}
