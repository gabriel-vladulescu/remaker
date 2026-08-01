using System;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	[Serializable]
	public class BurnBuffConfig : BuffConfig
	{
		public float interval;

		public float damageScale;

		public bool playVfx;

		public BurnBuffConfig()
		{
		}

		public BurnBuffConfig(BuffTargetModeInfoConfig buffTargetModeInfo, float duration, float successRate, float interval, float damageScale, bool playVfx)
		{
		}
	}
}
