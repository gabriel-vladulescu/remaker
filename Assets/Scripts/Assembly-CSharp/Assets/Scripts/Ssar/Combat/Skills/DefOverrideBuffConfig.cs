using System;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	[Serializable]
	public class DefOverrideBuffConfig : BuffConfig
	{
		public float percentage;

		public DefOverrideBuffConfig()
		{
		}

		public DefOverrideBuffConfig(BuffTargetModeInfoConfig buffTargetModeInfo, float duration, float successRate, float percentage)
		{
		}
	}
}
