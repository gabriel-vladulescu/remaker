using Assets.Scripts.Core.Skills.Modifiers;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic
{
	public class DefaultFrostInfo : FrostModifier.Info
	{
		private float duration;

		private float freezeDuration;

		private float successRate;

		private float movementSpeedBonus;

		private int freezeStack;

		public DefaultFrostInfo(float duration, float freezeDuration, float successRate, float movementSpeedBonus, int freezeStack)
		{
		}

		public float Duration()
		{
			return 0f;
		}

		public float FreezeDuration()
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

		public int FreezeStack()
		{
			return 0;
		}
	}
}
