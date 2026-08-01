using System;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	[Serializable]
	public class ReduceDamagePercentageBuffConfig : BuffConfig
	{
		public float reduction;

		public ReduceDamagePercentageBuffConfig()
		{
		}

		public ReduceDamagePercentageBuffConfig(BuffTargetModeInfoConfig buffTargetModeInfo, float duration, float successRate, float reduction)
		{
		}
	}
}
