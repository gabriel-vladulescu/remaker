using System;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	[Serializable]
	public class CursedBuffConfig : BuffConfig
	{
		public float attackBonus;

		public float movementSpeedBonus;

		public CursedBuffConfig()
		{
		}

		public CursedBuffConfig(BuffTargetModeInfoConfig buffTargetModeInfo, float duration, float successRate, float attackBonus, float movementSpeedBonus)
		{
		}
	}
}
