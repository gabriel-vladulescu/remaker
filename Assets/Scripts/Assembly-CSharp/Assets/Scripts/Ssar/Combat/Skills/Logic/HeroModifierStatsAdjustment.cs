using Assets.Scripts.Config.Stats;
using SSAR.SkillSystem.Model;
using Scripts.Config;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic
{
	public class HeroModifierStatsAdjustment : ModifierStatsAdjustment
	{
		private SkillConfigId skillConfigId;

		private HeroConfig heroConfig;

		private SkillEquippedData characterSkillData;

		private HeroData heroData;

		public HeroModifierStatsAdjustment(SkillConfigId skillConfigId, HeroConfig heroConfig, SkillEquippedData characterSkillData, HeroData heroData)
		{
		}

		public virtual float AdjustBurnSuccessRate(float origin)
		{
			return 0f;
		}

		public virtual float AdjustKnockbackSuccessRate(float origin)
		{
			return 0f;
		}

		public virtual float AdjustDefSuccessRate(float origin)
		{
			return 0f;
		}

		public float AdjustAttackBonusSuccessRate(float origin)
		{
			return 0f;
		}

		public float AdjustReduceDamagePercentageReduction(float origin)
		{
			return 0f;
		}

		public float AdjustAttackBonus(float origin)
		{
			return 0f;
		}

		public float AdjustCritDamageOverrideMultiplier(float origin)
		{
			return 0f;
		}

		public float AdjustAttackOverrideBonus(float origin)
		{
			return 0f;
		}

		public float AdjustCritRateOverride(float origin)
		{
			return 0f;
		}

		public float AdjustMaxHpOverride(float origin)
		{
			return 0f;
		}

		public float AdjustDefOverride(float origin)
		{
			return 0f;
		}

		public float AdjustMagicResistOverride(float origin)
		{
			return 0f;
		}

		public float AdjustIgnoreDefChance(float origin)
		{
			return 0f;
		}

		public float AdjustMoveSuccessRate(float origin)
		{
			return 0f;
		}

		public float AdjustCursedSuccessRate(float origin)
		{
			return 0f;
		}

		public float AdjustColdBurnSuccessRate(float origin)
		{
			return 0f;
		}

		public float AdjustShockSuccessRate(float origin)
		{
			return 0f;
		}

		public float AdjustSkillCritRate(float origin)
		{
			return 0f;
		}

		public float AdjustDarkArcaneDurationExtension(float origin)
		{
			return 0f;
		}

		public bool AutoRecoveryHpAfterAdjust()
		{
			return false;
		}

		private ModifierStats ShowModifierStatsOfSkillTactic(SkillConfigId sci)
		{
			return default(ModifierStats);
		}
	}
}
