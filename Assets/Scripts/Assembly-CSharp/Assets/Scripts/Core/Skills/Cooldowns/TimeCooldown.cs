namespace Assets.Scripts.Core.Skills.Cooldowns
{
	public class TimeCooldown : Cooldown
	{
		private float duration;

		private float remaining;

		public TimeCooldown(float duration)
		{
		}

		public void Start()
		{
		}

		public float RemainingPercentage()
		{
			return 0f;
		}

		public float Remaining()
		{
			return 0f;
		}

		public float Duration()
		{
			return 0f;
		}

		public void Update(float dt)
		{
		}

		public bool IsComplete()
		{
			return false;
		}

		public void Reset()
		{
		}

		public void AdjustRemainingWithRatio(float value)
		{
		}

		public void AdjustRemainingWithRawValue(float value)
		{
		}

		public void AdjustDurationWithRatio(float value)
		{
		}
	}
}
