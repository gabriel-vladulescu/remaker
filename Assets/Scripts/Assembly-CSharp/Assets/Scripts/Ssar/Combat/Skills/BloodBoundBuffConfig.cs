using System;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	[Serializable]
	public class BloodBoundBuffConfig : BuffConfig
	{
		public float damageScale;

		public float interval;

		public string jointNames;

		public BloodBoundBuffConfig()
		{
		}

		public BloodBoundBuffConfig(BuffTargetModeInfoConfig buffTargetModeInfo, float duration, float successRate, float damageScale, float interval, bool isLifeCycleDependOnParentSkill, string jointNames)
		{
		}
	}
}
