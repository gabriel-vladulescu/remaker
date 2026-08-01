using Artemis;

namespace SSAR.BattleSystem.AI
{
	public class TargetSkillRangeLogic
	{
		private readonly Entity self;

		private readonly Entity taget;

		public TargetSkillRangeLogic(Entity self, Entity taget)
		{
		}

		public SkillHitBoxInfo GetSkillHitBoxInfo(string skillId)
		{
			return null;
		}

		public bool IsInRangeSkill(SkillHitBoxInfo skillHitBoxInfo)
		{
			return false;
		}
	}
}
