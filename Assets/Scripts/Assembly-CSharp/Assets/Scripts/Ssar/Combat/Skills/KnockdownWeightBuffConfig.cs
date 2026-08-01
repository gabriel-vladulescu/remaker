using System;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	[Serializable]
	public class KnockdownWeightBuffConfig : BuffConfig
	{
		public float weight;

		public KnockdownWeightBuffConfig()
		{
		}

		public KnockdownWeightBuffConfig(BuffTargetModeInfoConfig buffTargetModeInfo, float duration, float successRate, float weight)
		{
		}
	}
}
