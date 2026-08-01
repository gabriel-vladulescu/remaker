using Assets.Scripts.Core.Skills.Modifiers;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic
{
	public class DefaultBurnInfo : BurnModifier.BurnInfo
	{
		private float successRate;

		private float duration;

		private float interval;

		private float damageScale;

		private bool playVfx;

		public DefaultBurnInfo(float successRate, float duration, float interval, float damageScale, bool playVfx)
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
}
