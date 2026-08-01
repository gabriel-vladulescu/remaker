using System;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	[Serializable]
	public class KnockbackWeightBuffConfig : BuffConfig
	{
		public float weight;

		public KnockbackWeightBuffConfig()
		{
		}

		public KnockbackWeightBuffConfig(BuffTargetModeInfoConfig buffTargetModeInfo, float duration, float successRate, float weight)
		{
		}
	}
}
