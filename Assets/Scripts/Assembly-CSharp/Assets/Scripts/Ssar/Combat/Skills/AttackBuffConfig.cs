using System;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	[Serializable]
	public class AttackBuffConfig : BuffConfig
	{
		public float bonus;

		public AttackBuffConfig()
		{
		}

		public AttackBuffConfig(BuffTargetModeInfoConfig buffTargetModeInfo, float duration, float successRate, float bonus)
		{
		}
	}
}
