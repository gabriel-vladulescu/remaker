using System;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	[Serializable]
	public class CritDamageBuffConfig : BuffConfig
	{
		public float damageMultiplier;

		public CritDamageBuffConfig()
		{
		}

		public CritDamageBuffConfig(BuffTargetModeInfoConfig buffTargetModeInfo, float duration, float successRate, float damageMultiplier)
		{
		}
	}
}
