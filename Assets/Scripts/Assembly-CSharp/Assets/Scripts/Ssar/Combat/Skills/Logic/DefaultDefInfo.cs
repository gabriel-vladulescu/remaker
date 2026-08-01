using Assets.Scripts.Core.Skills.Modifiers;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic
{
	public class DefaultDefInfo : DefModifier.DefInfo
	{
		private float successRate;

		private float duration;

		private float bonus;

		public DefaultDefInfo(float successRate, float duration, float bonus)
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

		public float Bonus()
		{
			return 0f;
		}
	}
}
