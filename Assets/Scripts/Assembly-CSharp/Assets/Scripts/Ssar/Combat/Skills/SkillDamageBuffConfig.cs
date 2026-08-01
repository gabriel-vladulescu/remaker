using System;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	[Serializable]
	public class SkillDamageBuffConfig : BuffConfig
	{
		public float bonus;

		public SkillDamageBuffConfig()
		{
		}

		public SkillDamageBuffConfig(BuffTargetModeInfoConfig buffTargetModeInfo, float duration, float successRate, float bonus, bool isLifeCycleDependOnParentSkill = false)
		{
		}
	}
}
