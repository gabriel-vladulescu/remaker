using System;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	[Serializable]
	public class WeaponPassiveSkillConfig
	{
		public float successRate;

		public float rawPower;

		public float hpPercent;

		public float hpThreshold;

		public float scalePower;

		public float duration;

		public float scalePower2;

		public float duration2;

		public float cooldown;

		public int stack;
	}
}
