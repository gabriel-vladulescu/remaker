using System;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	[Serializable]
	public class HpBuffConfig : BuffConfig
	{
		public float interval;

		public float percent;

		public HpBuffConfig()
		{
		}

		public HpBuffConfig(BuffTargetModeInfoConfig buffTargetModeInfo, float duration, float successRate, float interval, float percent)
		{
		}
	}
}
