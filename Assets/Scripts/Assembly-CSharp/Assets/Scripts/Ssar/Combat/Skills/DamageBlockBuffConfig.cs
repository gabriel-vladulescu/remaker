using System;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	[Serializable]
	public class DamageBlockBuffConfig : BuffConfig
	{
		public int blockCount;

		public float percentage;

		public DamageBlockBuffConfig()
		{
		}

		public DamageBlockBuffConfig(BuffTargetModeInfoConfig buffTargetModeInfo, float duration, float successRate, int blockCount, float percentage)
		{
		}
	}
}
