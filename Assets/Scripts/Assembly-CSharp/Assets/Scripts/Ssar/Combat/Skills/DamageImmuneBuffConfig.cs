using System;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	[Serializable]
	public class DamageImmuneBuffConfig : BuffConfig
	{
		public DamageImmuneBuffConfig()
		{
		}

		public DamageImmuneBuffConfig(BuffTargetModeInfoConfig buffTargetModeInfo, float duration, float successRate, bool isLifeCycleDependOnParentSkill = false)
		{
		}
	}
}
