using System;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	[Serializable]
	public class ColdBurnBuffConfig : BuffConfig
	{
		public float movementSpeedBonus;

		public float burnInterval;

		public float burnDamageScale;

		public bool playVfx;

		public ColdBurnBuffConfig()
		{
		}

		public ColdBurnBuffConfig(BuffTargetModeInfoConfig buffTargetModeInfo, float duration, float successRate, float movementSpeedBonus, float burnInterval, float burnDamageScale)
		{
		}
	}
}
