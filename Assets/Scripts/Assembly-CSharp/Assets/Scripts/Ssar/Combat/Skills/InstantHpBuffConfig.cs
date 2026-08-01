using System;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	[Serializable]
	public class InstantHpBuffConfig : BuffConfig
	{
		public float point;

		public float percent;

		public bool isShowDamage;

		public bool playVfx;

		public InstantHpBuffConfig()
		{
		}

		public InstantHpBuffConfig(BuffTargetModeInfoConfig buffTargetModeInfo, float duration, float successRate, float point, float percent, bool isShowDamage, bool playVfx)
		{
		}
	}
}
