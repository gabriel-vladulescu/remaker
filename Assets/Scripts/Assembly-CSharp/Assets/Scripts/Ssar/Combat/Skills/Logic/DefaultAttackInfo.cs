using Assets.Scripts.Core.Skills.Modifiers;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic
{
	public class DefaultAttackInfo : AttackModifier.AttackInfo
	{
		private float successRate;

		private float duration;

		private float bonus;

		private bool shouldPlayVfx;

		public DefaultAttackInfo(float successRate, float duration, float bonus, bool shouldPlayVfx)
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

		public bool ShouldPlayVfx()
		{
			return false;
		}
	}
}
