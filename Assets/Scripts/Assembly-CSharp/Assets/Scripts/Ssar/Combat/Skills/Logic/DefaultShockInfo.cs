using Assets.Scripts.Core.Skills.Modifiers;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic
{
	public class DefaultShockInfo : ShockModifier.ShockInfo
	{
		private float successRate;

		private float duration;

		private float movementSpeedBonus;

		private float additionalDamageAmplifier;

		public DefaultShockInfo(float successRate, float duration, float movementSpeedBonus, float additionalDamageAmplifier)
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

		public float MovementSpeedBonus()
		{
			return 0f;
		}

		public float AdditionalDamageAmplifier()
		{
			return 0f;
		}
	}
}
