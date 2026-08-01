using Assets.Scripts.Core.Skills.Modifiers;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic
{
	public class DefaultMovementSpeedInfo : MovementSpeedModifier.MovementSpeedInfo
	{
		private float successRate;

		private float duration;

		private float bonus;

		private bool shouldPlayVfx;

		private bool isLifeCycleDependOnParentSkill;

		public DefaultMovementSpeedInfo(float successRate, float duration, float bonus, bool shouldPlayVfx, bool isLifeCycleDependOnParentSkill)
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

		public bool IsLifeCycleDependOnParentSkill()
		{
			return false;
		}
	}
}
