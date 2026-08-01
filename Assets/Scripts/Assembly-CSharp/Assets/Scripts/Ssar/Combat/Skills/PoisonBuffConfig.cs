using System;
using SSAR.BattleSystem.Damage;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	[Serializable]
	public class PoisonBuffConfig : BuffConfig
	{
		public float movementSpeedBonus;

		public float damageInterval;

		public float damageScale;

		public bool playVfx;

		public string fxPath;

		public DamageType damageType;

		public PoisonBuffConfig()
		{
		}

		public PoisonBuffConfig(BuffTargetModeInfoConfig buffTargetModeInfo, float duration, float successRate, float movementSpeedBonus, float damageInterval, float damageScale, string fxPath, DamageType damageType)
		{
		}
	}
}
