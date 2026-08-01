using Assets.Scripts.Core.Skills;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	public class SkillDataToSkillConfigAdapter : Skill.Config
	{
		private SkillData skillData;

		public SkillDataToSkillConfigAdapter(SkillData skillData)
		{
		}

		public float Duration()
		{
			return 0f;
		}

		public float ChannelingDuration()
		{
			return 0f;
		}

		public bool IsActiveSkill()
		{
			return false;
		}
	}
}
