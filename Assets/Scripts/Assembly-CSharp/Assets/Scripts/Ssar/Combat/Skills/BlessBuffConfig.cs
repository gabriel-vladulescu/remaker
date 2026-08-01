using System;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	[Serializable]
	public class BlessBuffConfig : BuffConfig
	{
		public float defBonus;

		public float attackBonus;

		public float instantHp;

		public BlessBuffConfig()
		{
		}

		public BlessBuffConfig(BuffTargetModeInfoConfig buffTargetModeInfo, float duration, float successRate, float defBonus, float attackBonus, float instantHp)
		{
		}
	}
}
