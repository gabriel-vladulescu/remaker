using System;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	[Serializable]
	public class WildHowlBuffConfig : BuffConfig
	{
		public float attackBonus;

		public WildHowlBuffConfig()
		{
		}

		public WildHowlBuffConfig(BuffTargetModeInfoConfig buffTargetModeInfo, float duration, float successRate, float attackBonus)
		{
		}
	}
}
