namespace Assets.Scripts.Ssar.Combat.Skills.Logic
{
	public interface ModifierStatsAdjustment
	{
		float AdjustBurnSuccessRate(float origin);

		float AdjustKnockbackSuccessRate(float origin);

		float AdjustDefSuccessRate(float origin);

		float AdjustAttackBonusSuccessRate(float origin);

		float AdjustReduceDamagePercentageReduction(float origin);

		float AdjustAttackBonus(float origin);

		float AdjustCritDamageOverrideMultiplier(float origin);

		float AdjustAttackOverrideBonus(float origin);

		float AdjustCritRateOverride(float origin);

		float AdjustMaxHpOverride(float origin);

		float AdjustDefOverride(float origin);

		float AdjustMagicResistOverride(float origin);

		float AdjustIgnoreDefChance(float origin);

		float AdjustMoveSuccessRate(float origin);

		float AdjustCursedSuccessRate(float origin);

		float AdjustColdBurnSuccessRate(float origin);

		float AdjustShockSuccessRate(float origin);

		float AdjustSkillCritRate(float origin);

		float AdjustDarkArcaneDurationExtension(float origin);

		bool AutoRecoveryHpAfterAdjust();
	}
}
