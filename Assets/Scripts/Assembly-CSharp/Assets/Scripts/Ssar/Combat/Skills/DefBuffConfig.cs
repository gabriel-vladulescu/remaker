using System;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	[Serializable]
	public class DefBuffConfig : BuffConfig
	{
		public float bonus;

		public DefBuffConfig()
		{
		}

		public DefBuffConfig(BuffTargetModeInfoConfig buffTargetModeInfo, float duration, float successRate, float bonus)
		{
		}
	}
}
