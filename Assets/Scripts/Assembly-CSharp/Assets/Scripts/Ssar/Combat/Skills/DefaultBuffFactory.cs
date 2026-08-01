using Artemis;
using Assets.Scripts.Core.Skills;
using Assets.Scripts.Core.Skills.Modifiers;
using Assets.Scripts.Ssar.Combat.Skills.Logic;
using SSAR.BattleSystem.Damage;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	public class DefaultBuffFactory : BuffFactory
	{
		public class DefaultWildHowlInfo : WildHowlModifier.Info
		{
			private WildHowlBuff wildHowlBuff;

			private float scalePower;

			public DefaultWildHowlInfo(WildHowlBuff wildHowlBuff, float scalePower)
			{
			}

			public float AtkBonus()
			{
				return 0f;
			}

			public float Duration()
			{
				return 0f;
			}

			public float ScalePower()
			{
				return 0f;
			}
		}

		public class DefaultBlessInfo : BlessModifier.Info
		{
			private BlessBuff blessBuff;

			private float scalePower;

			public DefaultBlessInfo(BlessBuff blessBuff, float scalePower)
			{
			}

			public float AtkBonus()
			{
				return 0f;
			}

			public float DefBonus()
			{
				return 0f;
			}

			public float HealBonus()
			{
				return 0f;
			}

			public float ScalePower()
			{
				return 0f;
			}

			public float Duration()
			{
				return 0f;
			}
		}

		public class DefaultWarcryInfo : WarcryModifier.Info
		{
			private WarcryBuff warcryBuff;

			private float scalePower;

			public DefaultWarcryInfo(WarcryBuff warcryBuff, float scalePower)
			{
			}

			public float DefBonus()
			{
				return 0f;
			}

			public float AtkBonus()
			{
				return 0f;
			}

			public float Duration()
			{
				return 0f;
			}

			public float ScalePower()
			{
				return 0f;
			}
		}

		public class DefaultWarcryFxInfo : WarcryFxModifier.Info
		{
			private WarcryFxBuff warcryBuff;

			private float scalePower;

			public DefaultWarcryFxInfo(WarcryFxBuff warcryBuff, float scalePower)
			{
			}

			public float DefBonus()
			{
				return 0f;
			}

			public float AtkBonus()
			{
				return 0f;
			}

			public float Duration()
			{
				return 0f;
			}

			public float ScalePower()
			{
				return 0f;
			}

			public string StartupFxPath()
			{
				return null;
			}

			public string ActiveFxPath()
			{
				return null;
			}

			public Vector3 Offset()
			{
				return default(Vector3);
			}

			public Vector3 Scale()
			{
				return default(Vector3);
			}
		}

		public class DefaultHolyInfo : HolyModifier.Info
		{
			private HolyBuff hb;

			private float scalePower;

			public DefaultHolyInfo(HolyBuff hb, float scalePower)
			{
			}

			public float DamageReduction()
			{
				return 0f;
			}

			public float AttackBonus()
			{
				return 0f;
			}

			public float InstantHp()
			{
				return 0f;
			}

			public float Duration()
			{
				return 0f;
			}

			public float ScalePower()
			{
				return 0f;
			}
		}

		public class DefaultImmuneInfo : ImmuneModifier.ImmuneInfo
		{
			private ImmuneBuff immune;

			public DefaultImmuneInfo(ImmuneBuff immune)
			{
			}

			public float SuccessRate()
			{
				return 0f;
			}

			public float Duration()
			{
				return 0f;
			}

			public bool ShouldPlayLoopVfx()
			{
				return false;
			}

			public bool ShouldPlayFlashVfx()
			{
				return false;
			}

			public bool Physical()
			{
				return false;
			}

			public bool Magical()
			{
				return false;
			}

			public bool Pure()
			{
				return false;
			}

			public bool IsLifeCycleDependOnParentSkill()
			{
				return false;
			}
		}

		private class DefaultMovementSpeedInfo : MovementSpeedModifier.MovementSpeedInfo
		{
			private MovementSpeedBuff ms;

			public DefaultMovementSpeedInfo(MovementSpeedBuff ms)
			{
			}

			public float SuccessRate()
			{
				return 0f;
			}

			public float Duration()
			{
				return 0f;
			}

			public float Bonus()
			{
				return 0f;
			}

			public bool ShouldPlayVfx()
			{
				return false;
			}

			public bool IsLifeCycleDependOnParentSkill()
			{
				return false;
			}
		}

		private class DefaultAttackInfo : AttackModifier.AttackInfo
		{
			private AttackBuff attackBuff;

			private ModifierStatsAdjustment msa;

			public DefaultAttackInfo(AttackBuff attackBuff, ModifierStatsAdjustment msa)
			{
			}

			public float SuccessRate()
			{
				return 0f;
			}

			public float Duration()
			{
				return 0f;
			}

			public float Bonus()
			{
				return 0f;
			}

			public bool ShouldPlayVfx()
			{
				return false;
			}
		}

		private class DefaultDefInfo : DefModifier.DefInfo
		{
			private DefBuff defBuff;

			public DefaultDefInfo(DefBuff defBuff)
			{
			}

			public float SuccessRate()
			{
				return 0f;
			}

			public float Duration()
			{
				return 0f;
			}

			public float Bonus()
			{
				return 0f;
			}
		}

		private class DefaultBurnInfo : BurnModifier.BurnInfo
		{
			private BurnBuff burnBuff;

			public DefaultBurnInfo(BurnBuff burnBuff)
			{
			}

			public float SuccessRate()
			{
				return 0f;
			}

			public float Duration()
			{
				return 0f;
			}

			public float Interval()
			{
				return 0f;
			}

			public float DamageScale()
			{
				return 0f;
			}

			public bool ShouldPlayVfx()
			{
				return false;
			}
		}

		private class DefaultHpInfo : HpModifier.HpInfo
		{
			private HpBuff hpBuff;

			public DefaultHpInfo(HpBuff hpBuff)
			{
			}

			public float SuccessRate()
			{
				return 0f;
			}

			public float Duration()
			{
				return 0f;
			}

			public float Interval()
			{
				return 0f;
			}

			public float Percent()
			{
				return 0f;
			}
		}

		private class DefaultInstantHpInfo : InstantHpModifierWithText.Info
		{
			private float percentage;

			private float point;

			private string effectPath;

			public DefaultInstantHpInfo(InstantHpBuff buff)
			{
			}

			public float Percentage()
			{
				return 0f;
			}

			public float Point()
			{
				return 0f;
			}

			public string EffectPath()
			{
				return null;
			}
		}

		private class DefaultReduceDamageByDistanceInfo : ReduceDamageByDistanceModifier.ReduceDamageByDistanceInfo
		{
			private ReduceDamageByDistanceBuff buff;

			public DefaultReduceDamageByDistanceInfo(ReduceDamageByDistanceBuff buff)
			{
			}

			public float Duration()
			{
				return 0f;
			}

			public float Distance()
			{
				return 0f;
			}

			public float From()
			{
				return 0f;
			}

			public float To()
			{
				return 0f;
			}
		}

		private class DefaultReduceDamagePercentageInfo : ReduceDamagePercentageModifier.Info
		{
			private ReduceDamagePercentageBuff buff;

			private ModifierStatsAdjustment msa;

			public DefaultReduceDamagePercentageInfo(ReduceDamagePercentageBuff buff, ModifierStatsAdjustment msa)
			{
			}

			public float Duration()
			{
				return 0f;
			}

			public float Reduction()
			{
				return 0f;
			}
		}

		private class DefaultCritDamageInfo : CritDamageModifier.Info
		{
			private CritDamageBuff buff;

			private ModifierStatsAdjustment msa;

			public DefaultCritDamageInfo(CritDamageBuff buff, ModifierStatsAdjustment msa)
			{
			}

			public float Duration()
			{
				return 0f;
			}

			public float DamageMultiplier()
			{
				return 0f;
			}
		}

		private class AttackOverrideBuffToAttackInfoAdapter : AttackModifier.AttackInfo
		{
			private AttackOverrideBuff aob;

			private ModifierStatsAdjustment msa;

			public AttackOverrideBuffToAttackInfoAdapter(AttackOverrideBuff aob, ModifierStatsAdjustment msa)
			{
			}

			public float SuccessRate()
			{
				return 0f;
			}

			public float Duration()
			{
				return 0f;
			}

			public float Bonus()
			{
				return 0f;
			}

			public bool ShouldPlayVfx()
			{
				return false;
			}
		}

		private class DefaultCritRateOverrideInfo : CritRateOverrideModifier.Info
		{
			private CritRateOverrideBuff crob;

			private ModifierStatsAdjustment msa;

			public DefaultCritRateOverrideInfo(CritRateOverrideBuff crob, ModifierStatsAdjustment msa)
			{
			}

			public float Duration()
			{
				return 0f;
			}

			public float Rate()
			{
				return 0f;
			}
		}

		private class DefaultMaxHpOverrideInfo : MaxHpOverrideModifier.Info
		{
			private MaxHpOverrideBuff mhob;

			private ModifierStatsAdjustment msa;

			public DefaultMaxHpOverrideInfo(MaxHpOverrideBuff mhob, ModifierStatsAdjustment msa)
			{
			}

			public float Duration()
			{
				return 0f;
			}

			public float Percentage()
			{
				return 0f;
			}

			public bool IsRecoveryHp()
			{
				return false;
			}
		}

		private class DefaultDefOverrideInfo : DefOverrideModifier.Info
		{
			private DefOverrideBuff dob;

			private ModifierStatsAdjustment msa;

			public DefaultDefOverrideInfo(DefOverrideBuff dob, ModifierStatsAdjustment msa)
			{
			}

			public float Duration()
			{
				return 0f;
			}

			public float Percentage()
			{
				return 0f;
			}
		}

		private class DefaultMagicResistOverrideInfo : MagicResistOverrideModifier.Info
		{
			private MagicResistOverrideBuff mrob;

			private ModifierStatsAdjustment msa;

			public DefaultMagicResistOverrideInfo(MagicResistOverrideBuff mrob, ModifierStatsAdjustment msa)
			{
			}

			public float Duration()
			{
				return 0f;
			}

			public float Percentage()
			{
				return 0f;
			}
		}

		private class DefaultVanishInfo : VanishModifier.Info
		{
			private VanishBuff vb;

			public DefaultVanishInfo(VanishBuff vb)
			{
			}

			public float Duration()
			{
				return 0f;
			}
		}

		private class DefaultDamageBlockInfo : DamageBlockModifier.Info
		{
			private DamageBlockBuff dbb;

			public DefaultDamageBlockInfo(DamageBlockBuff dbb)
			{
			}

			public float SuccessRate()
			{
				return 0f;
			}

			public float Duration()
			{
				return 0f;
			}

			public int BlockCount()
			{
				return 0;
			}

			public float ReductionByPercentage()
			{
				return 0f;
			}
		}

		private class DefaultKnockbackWeightInfo : KnockbackWeightModifier.Info
		{
			private KnockbackWeightBuff kwb;

			public DefaultKnockbackWeightInfo(KnockbackWeightBuff kwb)
			{
			}

			public float SuccessRate()
			{
				return 0f;
			}

			public float Duration()
			{
				return 0f;
			}

			public float Weight()
			{
				return 0f;
			}
		}

		private class DefaultKnockdownWeightInfo : KnockdownWeightModifier.Info
		{
			private KnockdownWeightBuff kwb;

			public DefaultKnockdownWeightInfo(KnockdownWeightBuff kwb)
			{
			}

			public float SuccessRate()
			{
				return 0f;
			}

			public float Duration()
			{
				return 0f;
			}

			public float Weight()
			{
				return 0f;
			}
		}

		private class DefaultSkillCritRateInfo : SkillCritRateModifier.Info
		{
			private SkillCritRateBuff scrb;

			private ModifierStatsAdjustment msa;

			public DefaultSkillCritRateInfo(SkillCritRateBuff scrb, ModifierStatsAdjustment msa)
			{
			}

			public float Duration()
			{
				return 0f;
			}

			public float Rate()
			{
				return 0f;
			}
		}

		private class DefaultSkillDamageInfo : SkillDamageModifier.Info
		{
			private SkillDamageBuff skillDamageBuff;

			public DefaultSkillDamageInfo(SkillDamageBuff skillDamageBuff)
			{
			}

			public float SuccessRate()
			{
				return 0f;
			}

			public float Duration()
			{
				return 0f;
			}

			public float Bonus()
			{
				return 0f;
			}

			public bool ShouldPlayVfx()
			{
				return false;
			}
		}

		private class DefaultMagicDamageBlockInfo : MagicDamageBlockModifier.Info
		{
			private MagicDamageBlockBuff buff;

			public DefaultMagicDamageBlockInfo(MagicDamageBlockBuff buff)
			{
			}

			public float SuccessRate()
			{
				return 0f;
			}

			public float Duration()
			{
				return 0f;
			}

			public float Bonus()
			{
				return 0f;
			}
		}

		private class DefaultDodgeInfo : DodgeModifier.Info
		{
			private DodgeBuff buff;

			public DefaultDodgeInfo(DodgeBuff buff)
			{
			}

			public float SuccessRate()
			{
				return 0f;
			}

			public float Duration()
			{
				return 0f;
			}

			public float Bonus()
			{
				return 0f;
			}

			public float RawBonus()
			{
				return 0f;
			}

			public bool ShouldPlayVfx()
			{
				return false;
			}
		}

		private class DefaultDamageReductionInfo : DamageReductionModifier.Info
		{
			private DamageReductionBuff buff;

			public DefaultDamageReductionInfo(DamageReductionBuff buff)
			{
			}

			public float SuccessRate()
			{
				return 0f;
			}

			public float Duration()
			{
				return 0f;
			}

			public float Bonus()
			{
				return 0f;
			}

			public float RawBonus()
			{
				return 0f;
			}

			public bool ShouldPlayVfx()
			{
				return false;
			}
		}

		private class DefaultCooldownInfo : CooldownModifier.Info
		{
			private CooldownBuff buff;

			public DefaultCooldownInfo(CooldownBuff buff)
			{
			}

			public float SuccessRate()
			{
				return 0f;
			}

			public CooldownModifier.Mode Mode()
			{
				return default(CooldownModifier.Mode);
			}

			public float Percentage()
			{
				return 0f;
			}

			public float RawValue()
			{
				return 0f;
			}

			public bool ShouldPlayVfx()
			{
				return false;
			}

			public string Source()
			{
				return null;
			}
		}

		private class BuffPoisonInfo : PoisonModifier.Info
		{
			private PoisonBuff buff;

			public BuffPoisonInfo(PoisonBuff buff)
			{
			}

			public float SuccessRate()
			{
				return 0f;
			}

			public float Duration()
			{
				return 0f;
			}

			public float MovementSpeedBonus()
			{
				return 0f;
			}

			public float DamageInterval()
			{
				return 0f;
			}

			public float DamageScale()
			{
				return 0f;
			}

			public bool ShouldPlayVfx()
			{
				return false;
			}

			public string FxPath()
			{
				return null;
			}

			public DamageType DamageType()
			{
				return default(DamageType);
			}
		}

		private class BuffSilentInfo : SilentModifier.Info
		{
			private SilentBuff buff;

			public BuffSilentInfo(SilentBuff buff)
			{
			}

			public float SuccessRate()
			{
				return 0f;
			}

			public float Duration()
			{
				return 0f;
			}

			public bool PlayVfx()
			{
				return false;
			}
		}

		private EntityWorld entityWorld;

		private ModifierStatsAdjustment modifierStatsAdjustment;

		private float skillScalePower;

		public DefaultBuffFactory(EntityWorld entityWorld, ModifierStatsAdjustment modifierStatsAdjustment, float skillScalePower)
		{
		}

		public bool Create(EventFrame ef, Character caster, Character target, ref Modifier modifier)
		{
			return false;
		}
	}
}
