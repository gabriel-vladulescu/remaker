using Assets.Scripts.Core.Skills.Modifiers;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic
{
	public class DefaultActiveSkillCooldownModifierInfo : ActiveSkillCooldownModifier.Info
	{
		private float ratio;

		private float duration;

		public DefaultActiveSkillCooldownModifierInfo(float ratio, float duration)
		{
		}

		public float Duration()
		{
			return 0f;
		}

		public float Ratio()
		{
			return 0f;
		}
	}
}
