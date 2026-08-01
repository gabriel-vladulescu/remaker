using System;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	[Serializable]
	public class SilentBuffConfig : BuffConfig
	{
		public bool playVfx;

		public SilentBuffConfig()
		{
		}

		public SilentBuffConfig(BuffTargetModeInfoConfig buffTargetModeInfo, float duration, float successRate, bool playVfx, bool isLifeCycleDependOnParentSkill = false)
		{
		}
	}
}
