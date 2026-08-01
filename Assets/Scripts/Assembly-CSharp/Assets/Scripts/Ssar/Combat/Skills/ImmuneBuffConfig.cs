using System;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	[Serializable]
	public class ImmuneBuffConfig : BuffConfig
	{
		public bool physical;

		public bool magical;

		public bool pure;

		public bool playLoopVfx;

		public bool playFlashVfx;

		public ImmuneBuffConfig()
		{
		}

		public ImmuneBuffConfig(BuffTargetModeInfoConfig buffTargetModeInfo, float duration, float successRate, bool playLoopVfx = true, bool physical = true, bool magical = true, bool pure = true, bool playFlashVfx = true)
		{
		}
	}
}
