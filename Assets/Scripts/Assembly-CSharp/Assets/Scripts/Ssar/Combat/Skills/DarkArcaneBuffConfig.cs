using System;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	[Serializable]
	public class DarkArcaneBuffConfig : BuffConfig
	{
		public float skillDurationExtensionPerKill;

		public DarkArcaneBuffConfig()
		{
		}

		public DarkArcaneBuffConfig(BuffTargetModeInfoConfig buffTargetModeInfo, float duration, float successRate, bool isLifeCycleDependOnParentSkill, float skillDurationExtensionPerKill)
		{
		}
	}
}
