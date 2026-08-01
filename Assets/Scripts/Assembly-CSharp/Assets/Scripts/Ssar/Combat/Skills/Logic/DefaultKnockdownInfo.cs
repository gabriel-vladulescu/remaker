using Assets.Scripts.Core.Skills.Modifiers;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic
{
	public class DefaultKnockdownInfo : KnockdownModifier.KnockdownInfo
	{
		private float successRate;

		private float level;

		private float height;

		private float durationReachMaxHeight;

		private float durationLandGround;

		private float distance;

		private readonly float duration;

		private bool shouldUseCasterPositionForKnockdownDirection;

		private float floatingDuration;

		private bool shouldPerformBouncing;

		private bool shouldUseCasterFacingDirectionForKnockdownDirection;

		private bool shouldUserProjectileVelocityForKnockdownDirection;

		public DefaultKnockdownInfo(float successRate, float level, float height, float durationReachMaxHeight, float durationLandGround, float distance, float duration, bool shouldUseCasterPositionForKnockdownDirection, bool shouldUseCasterFacingDirectionForKnockdownDirection, bool shouldUserProjectileVelocityForKnockdownDirection, float floatingDuration = 0f, bool shouldPerformBouncing = true)
		{
		}

		public float SuccessRate()
		{
			return 0f;
		}

		public float Level()
		{
			return 0f;
		}

		public float Height()
		{
			return 0f;
		}

		public float DurationReachMaxHeight()
		{
			return 0f;
		}

		public float DurationLandGround()
		{
			return 0f;
		}

		public float Distance()
		{
			return 0f;
		}

		public float Duration()
		{
			return 0f;
		}

		public bool ShouldUseCasterPositionForKnockdownDirection()
		{
			return false;
		}

		public float FloatingDuration()
		{
			return 0f;
		}

		public bool ShouldPerformBouncing()
		{
			return false;
		}

		public bool ShouldUseCasterFacingDirectionForKnockdownDirection()
		{
			return false;
		}

		public bool ShouldUserProjectileVelocityForKnockdownDirection()
		{
			return false;
		}
	}
}
