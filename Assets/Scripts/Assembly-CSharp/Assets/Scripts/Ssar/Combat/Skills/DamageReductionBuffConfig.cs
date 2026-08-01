using System;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	[Serializable]
	public class DamageReductionBuffConfig : BuffConfig
	{
		public float bonus;

		public float rawBonus;

		public bool playVfx;

		public DamageReductionBuffConfig()
		{
		}

		public DamageReductionBuffConfig(BuffTargetModeInfoConfig buffTargetModeInfo, float duration, float successRate, float bonus, float rawBonus, bool playVfx, bool isLifeCycleDependOnParentSkill = false)
		{
		}
	}
}
