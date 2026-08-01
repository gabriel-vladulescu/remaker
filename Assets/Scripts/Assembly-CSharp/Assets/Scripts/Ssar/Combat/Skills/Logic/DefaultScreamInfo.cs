using Assets.Scripts.Core.Skills.Modifiers;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic
{
	public class DefaultScreamInfo : ScreamModifier.Info
	{
		private float duration;

		private float successRate;

		private float movementSpeedBonus;

		private float attackBonus;

		private float damageMultiplier;

		public DefaultScreamInfo(float duration, float successRate, float movementSpeedBonus, float attackBonus, float damageMultiplier)
		{
		}

		public float Duration()
		{
			return 0f;
		}

		public float SuccessRate()
		{
			return 0f;
		}

		public float MovementSpeedBonus()
		{
			return 0f;
		}

		public float AttackBonus()
		{
			return 0f;
		}

		public float DamageMultiplier()
		{
			return 0f;
		}
	}
}
