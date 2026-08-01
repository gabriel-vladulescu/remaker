using System;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	[Serializable]
	public class DodgeBuffConfig : BuffConfig
	{
		public float bonus;

		public float rawBonus;

		public DodgeBuffConfig()
		{
		}

		public DodgeBuffConfig(BuffTargetModeInfoConfig buffTargetModeInfo, float duration, float successRate, float bonus, float rawBonus, bool isLifeCycleDependOnParentSkill = false)
		{
		}
	}
}
