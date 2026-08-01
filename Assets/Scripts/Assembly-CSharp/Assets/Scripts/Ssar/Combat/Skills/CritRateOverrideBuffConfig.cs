using System;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	[Serializable]
	public class CritRateOverrideBuffConfig : BuffConfig
	{
		public float rate;

		public CritRateOverrideBuffConfig()
		{
		}

		public CritRateOverrideBuffConfig(BuffTargetModeInfoConfig buffTargetModeInfo, float duration, float successRate, float rate)
		{
		}
	}
}
