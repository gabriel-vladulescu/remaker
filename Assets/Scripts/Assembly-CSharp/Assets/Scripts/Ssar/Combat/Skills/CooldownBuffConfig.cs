using System;
using Assets.Scripts.Core.Skills.Modifiers;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	[Serializable]
	public class CooldownBuffConfig : BuffConfig
	{
		public float bonus;

		public float rawBonus;

		public bool playVfx;

		public CooldownModifier.Mode mode;

		public CooldownBuffConfig()
		{
		}

		public CooldownBuffConfig(BuffTargetModeInfoConfig buffTargetModeInfo, float duration, float successRate, float bonus, float rawBonus, bool playVfx, CooldownModifier.Mode mode, bool isLifeCycleDependOnParentSkill = false)
		{
		}
	}
}
