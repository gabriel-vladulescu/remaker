using Assets.Scripts.Core.Skills.Modifiers;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic
{
	public class DefaultKnockBackInfo : KnockbackModifier.KnockbackInfo
	{
		private readonly float successRate;

		private KnockbackModifier.DashInfo dashInfo;

		private float knockbackLevel;

		private bool shouldInterruptTargetSkill;

		private bool shouldKnockbackTowardProjectile;

		private bool shouldUseCasterPositionForKnockbackDirection;

		private readonly bool alwaysKnockbackAccordingToCasterFacingDirection;

		public DefaultKnockBackInfo(float successRate, KnockbackModifier.DashInfo dashInfo, float knockbackLevel, bool shouldInterruptTargetSkill, bool shouldKnockbackTowardProjectile, bool shouldUseCasterPositionForKnockbackDirection, bool alwaysKnockbackAccordingToCasterFacingDirection)
		{
		}

		public float SuccessRate()
		{
			return 0f;
		}

		public KnockbackModifier.DashInfo DashInfo()
		{
			return null;
		}

		public float Level()
		{
			return 0f;
		}

		public bool ShouldInterruptTargetSkill()
		{
			return false;
		}

		public bool ShouldKnockbackTowardProjectile()
		{
			return false;
		}

		public bool ShouldUseCasterPositionForKnockbackDirection()
		{
			return false;
		}

		public bool AlwaysKnockbackAccordingToCasterFacingDirection()
		{
			return false;
		}
	}
}
