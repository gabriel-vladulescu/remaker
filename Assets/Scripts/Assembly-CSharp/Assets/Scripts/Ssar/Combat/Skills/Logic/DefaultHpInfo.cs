using Assets.Scripts.Core.Skills.Modifiers;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic
{
	public class DefaultHpInfo : HpModifier.HpInfo
	{
		private float successRate;

		private float duration;

		private float interval;

		private float percent;

		public DefaultHpInfo(float successRate, float duration, float interval, float percent)
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
}
