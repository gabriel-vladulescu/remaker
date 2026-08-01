using System;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	[Serializable]
	public class HpDropAttackBuffConfig : WeaponPassiveSkillConfig
	{
		public string bones;

		public string activationSfxPath;

		public string deactivationSfxPath;

		public HpDropAttackBuffConfig()
		{
		}

		public HpDropAttackBuffConfig(float scalePower, float hpThreshold, string bones, string activationSfxPath, string deactivationSfxPath)
		{
		}

		public string[] Bones()
		{
			return null;
		}
	}
}
