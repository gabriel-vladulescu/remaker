namespace Assets.Scripts.Core.Skills.Modifiers
{
	public class DefaultRuneHealthInfo : ArenaRuneHealthModifier.HpInfo
	{
		private readonly float _duration;

		private readonly float _percent;

		public DefaultRuneHealthInfo(float duration, float percent)
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

		public float DisableTime()
		{
			return 0f;
		}
	}
}
