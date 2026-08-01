using System.Collections.Generic;

namespace Assets.Scripts.Core.Skills.Cooldowns
{
	public class ChargeCooldown : Cooldown
	{
		private int max_charge;

		private readonly float duration;

		private int currentCharge;

		private TimeCooldown timeCooldown;

		private Queue<TimeCooldown> timeCooldowns;

		private bool adjust;

		private float ratio;

		private bool adjustRaw;

		private float rawValue;

		public int CurrentCharge => 0;

		public ChargeCooldown(float duration, int max_charge)
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

		public bool IsComplete()
		{
			return false;
		}

		public void Update(float dt)
		{
		}

		public void Reset()
		{
		}

		public void ConsumeAllCharges()
		{
		}

		public void AdjustRemainingWithRatio(float value)
		{
		}

		public void AdjustRemainingWithRawValue(float value)
		{
		}

		public void AdjustDurationWithRatio(float newValue)
		{
		}
	}
}
