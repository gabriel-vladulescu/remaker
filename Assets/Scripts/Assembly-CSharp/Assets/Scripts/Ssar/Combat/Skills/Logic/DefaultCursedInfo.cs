using Assets.Scripts.Core.Skills.Modifiers;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic
{
	public class DefaultCursedInfo : CurseModifier.Info
	{
		private float duration;

		private float successRate;

		private float movementSpeedBonus;

		private float attackBonus;

		private bool playVfx;

		public DefaultCursedInfo(float duration, float successRate, float movementSpeedBonus, float attackBonus, bool playVfx)
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

		public bool ShouldPlayVfx()
		{
			return false;
		}
	}
}
