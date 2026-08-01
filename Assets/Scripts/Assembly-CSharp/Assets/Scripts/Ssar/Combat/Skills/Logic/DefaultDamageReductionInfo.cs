using Assets.Scripts.Core.Skills.Modifiers;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic
{
	public class DefaultDamageReductionInfo : DamageReductionModifier.Info
	{
		private float successRate;

		private float duration;

		private float bonus;

		private float rawBonus;

		private bool playVfx;

		public DefaultDamageReductionInfo(float successRate, float duration, float bonus, float rawBonus, bool playVfx = false)
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

		public float RawBonus()
		{
			return 0f;
		}

		public bool ShouldPlayVfx()
		{
			return false;
		}
	}
}
