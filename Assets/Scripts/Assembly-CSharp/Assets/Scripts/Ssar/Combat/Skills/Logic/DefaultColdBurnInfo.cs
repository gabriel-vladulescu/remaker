using Assets.Scripts.Core.Skills.Modifiers;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic
{
	public class DefaultColdBurnInfo : ColdBurnModifier.Info
	{
		private float successRate;

		private float duration;

		private float movementSpeedBonus;

		private float burnInterval;

		private float burnDamageScale;

		private bool shouldPlayVfx;

		public DefaultColdBurnInfo(float successRate, float duration, float movementSpeedBonus, float burnInterval, float burnDamageScale, bool shouldPlayVfx)
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

		public float BurnInterval()
		{
			return 0f;
		}

		public float BurnDamageScale()
		{
			return 0f;
		}

		public bool ShouldPlayVfx()
		{
			return false;
		}
	}
}
