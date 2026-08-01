using System;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	[Serializable]
	public class MovementSpeedBuffConfig : BuffConfig
	{
		public float bonus;

		public bool playVfx;

		public MovementSpeedBuffConfig()
		{
		}

		public MovementSpeedBuffConfig(BuffTargetModeInfoConfig buffTargetModeInfo, float duration, float successRate, float bonus, bool playVfx)
		{
		}
	}
}
