using System;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	[Serializable]
	public class AttackOverrideBuffConfig : BuffConfig
	{
		public float bonus;

		public AttackOverrideBuffConfig()
		{
		}

		public AttackOverrideBuffConfig(BuffTargetModeInfoConfig buffTargetModeInfo, float duration, float successRate, float bonus)
		{
		}
	}
}
