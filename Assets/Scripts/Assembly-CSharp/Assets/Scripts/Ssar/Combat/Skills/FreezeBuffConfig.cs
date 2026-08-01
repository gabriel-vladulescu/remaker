using System;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	[Serializable]
	public class FreezeBuffConfig : BuffConfig
	{
		public bool playMaterialVfx;

		public bool playLockVfx;

		public FreezeBuffConfig()
		{
		}

		public FreezeBuffConfig(BuffTargetModeInfoConfig buffTargetModeInfo, float duration, float successRate, bool playMaterialVfx, bool playLockVfx)
		{
		}
	}
}
