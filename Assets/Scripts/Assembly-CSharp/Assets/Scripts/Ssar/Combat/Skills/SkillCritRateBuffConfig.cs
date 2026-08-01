using System;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	[Serializable]
	public class SkillCritRateBuffConfig : BuffConfig
	{
		public float rate;

		public SkillCritRateBuffConfig()
		{
		}

		public SkillCritRateBuffConfig(BuffTargetModeInfoConfig buffTargetModeInfo, float duration, float successRate, float rate)
		{
		}
	}
}
