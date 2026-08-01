using System;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	[Serializable]
	public class ShockBuffConfig : BuffConfig
	{
		public float movementSpeedBonus;

		public float additionalDamageAmplifier;

		public ShockBuffConfig()
		{
		}

		public ShockBuffConfig(BuffTargetModeInfoConfig buffTargetModeInfo, float duration, float successRate, float movementSpeedBonus, float additionalDamageAmplifier)
		{
		}
	}
}
