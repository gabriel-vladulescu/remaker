using System;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	[Serializable]
	public class MaxHpOverrideBuffConfig : BuffConfig
	{
		public float percentage;

		public MaxHpOverrideBuffConfig()
		{
		}

		public MaxHpOverrideBuffConfig(BuffTargetModeInfoConfig buffTargetModeInfo, float duration, float successRate, float percentage)
		{
		}
	}
}
