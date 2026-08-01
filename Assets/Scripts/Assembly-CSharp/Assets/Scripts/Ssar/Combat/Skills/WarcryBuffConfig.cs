using System;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	[Serializable]
	public class WarcryBuffConfig : BuffConfig
	{
		public float defBonus;

		public float attackBonus;

		public WarcryBuffConfig()
		{
		}

		public WarcryBuffConfig(BuffTargetModeInfoConfig buffTargetModeInfo, float duration, float successRate, float defBonus, float attackBonus)
		{
		}
	}
}
