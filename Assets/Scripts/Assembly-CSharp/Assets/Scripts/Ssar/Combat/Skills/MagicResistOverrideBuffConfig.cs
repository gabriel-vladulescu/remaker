using System;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	[Serializable]
	public class MagicResistOverrideBuffConfig : BuffConfig
	{
		public float percentage;

		public MagicResistOverrideBuffConfig()
		{
		}

		public MagicResistOverrideBuffConfig(BuffTargetModeInfoConfig buffTargetModeInfo, float duration, float successRate, float percentage)
		{
		}
	}
}
