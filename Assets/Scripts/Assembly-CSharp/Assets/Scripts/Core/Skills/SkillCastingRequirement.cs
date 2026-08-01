using Assets.Scripts.Core.Skills.Conditions;
using Assets.Scripts.Core.Skills.Cooldowns;

namespace Assets.Scripts.Core.Skills
{
	public class SkillCastingRequirement
	{
		private Cooldown cooldown;

		private Condition[] conditions;

		private bool enabled;

		public SkillCastingRequirement(Cooldown cooldown, Condition[] conditions)
		{
		}

		public void Update(float dt)
		{
		}

		public void SetEnable(bool isEnabled)
		{
		}

		public bool IsEnabled()
		{
			return false;
		}

		public bool IsCastable()
		{
			return false;
		}

		public void ResetCooldown()
		{
		}

		public void StartCooldown()
		{
		}

		public string Reasons()
		{
			return null;
		}

		public void AdjustRemainingOfTimeCooldownByRatio(float value)
		{
		}

		public void AdjustRemainingOfTimeCooldownByRawValue(float value)
		{
		}

		public void ConsumeAllCharges()
		{
		}

		public void AdjustDurationOfTimeCooldownByRatio(float newValue)
		{
		}

		public float GetRemaining()
		{
			return 0f;
		}

		public float GetDuration()
		{
			return 0f;
		}
	}
}
