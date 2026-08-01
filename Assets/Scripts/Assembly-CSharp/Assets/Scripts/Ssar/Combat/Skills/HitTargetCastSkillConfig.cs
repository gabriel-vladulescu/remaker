using System;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	[Serializable]
	public class HitTargetCastSkillConfig
	{
		public string targetId;

		public int skillOrder;

		public bool dontInterruptCurrentSkill;
	}
}
