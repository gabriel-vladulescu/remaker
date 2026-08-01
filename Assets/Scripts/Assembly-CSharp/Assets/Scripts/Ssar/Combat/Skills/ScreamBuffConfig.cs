using System;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	[Serializable]
	public class ScreamBuffConfig : BuffConfig
	{
		public float attackBonus;

		public float movementSpeedBonus;

		public float damageMultiplier;

		public ScreamBuffConfig()
		{
		}

		public ScreamBuffConfig(BuffTargetModeInfoConfig buffTargetModeInfo, float duration, float successRate, float attackBonus, float movementSpeedBonus, float damageMultiplier)
		{
		}
	}
}
