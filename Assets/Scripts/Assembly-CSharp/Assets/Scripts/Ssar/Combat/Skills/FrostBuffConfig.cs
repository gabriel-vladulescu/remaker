using System;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	[Serializable]
	public class FrostBuffConfig : BuffConfig
	{
		public float freezeDuration;

		public float movementSpeedBonus;

		public int freezeStack;

		public FrostBuffConfig()
		{
		}

		public FrostBuffConfig(BuffTargetModeInfoConfig buffTargetModeInfo, float duration, float successRate, float freezeDuration, float movementSpeedBonus, int freezeStack)
		{
		}
	}
}
