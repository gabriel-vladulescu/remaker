using System;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	[Serializable]
	public class CcImmuneBuffConfig : BuffConfig
	{
		public bool isPurification;

		public bool enableVfx;

		public CcImmuneBuffConfig()
		{
		}

		public CcImmuneBuffConfig(BuffTargetModeInfoConfig buffTargetModeInfo, float duration, float successRate, bool isLifeCycleDependOnParentSkill, bool isPurification, bool enableVfx)
		{
		}
	}
}
