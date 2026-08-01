using System;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	[Serializable]
	public class MagicDamageBlockBuffConfig : BuffConfig
	{
		public float bonus;

		public MagicDamageBlockBuffConfig()
		{
		}

		public MagicDamageBlockBuffConfig(BuffTargetModeInfoConfig buffTargetModeInfo, float duration, float successRate, float bonus, bool isLifeCycleDependOnParentSkill = false)
		{
		}
	}
}
