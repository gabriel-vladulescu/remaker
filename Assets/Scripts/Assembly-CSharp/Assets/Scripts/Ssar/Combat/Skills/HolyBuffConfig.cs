using System;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	[Serializable]
	public class HolyBuffConfig : BuffConfig
	{
		public float damageReduction;

		public float attackBonus;

		public float instantHp;

		public HolyBuffConfig()
		{
		}

		public HolyBuffConfig(BuffTargetModeInfoConfig buffTargetModeInfo, float duration, float successRate, float damageReduction, float attackBonus, float instantHp)
		{
		}
	}
}
