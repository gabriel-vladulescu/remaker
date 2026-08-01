using System;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	[Serializable]
	public class BleedBuffConfig : BuffConfig
	{
		public float interval;

		public float damageScale;

		public string damageType;

		public BleedBuffConfig()
		{
		}

		public BleedBuffConfig(BuffTargetModeInfoConfig buffTargetModeInfo, float duration, float successRate, float interval, float damageScale, string damageType)
		{
		}
	}
}
