using Assets.Scripts.Core.Skills.Modifiers;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic
{
	public class DefaultDashInfo : KnockbackModifier.DashInfo
	{
		private float distance;

		private float duration;

		public DefaultDashInfo(float distance, float duration)
		{
		}

		public float Distance()
		{
			return 0f;
		}

		public float Duration()
		{
			return 0f;
		}

		public void AdjustDistance(float newValue)
		{
		}
	}
}
