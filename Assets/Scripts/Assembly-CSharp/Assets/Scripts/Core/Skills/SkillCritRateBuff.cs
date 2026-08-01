namespace Assets.Scripts.Core.Skills
{
	public class SkillCritRateBuff : Buff
	{
		private float rate;

		public float Rate => 0f;

		public SkillCritRateBuff(BuffTargetModeInfo buffTargetModeInfo, float duration, float successRate, float rate, bool isLifeCycleDependOnParentSkill)
			: base(default(BuffType), null, 0f, 0f, isLifeCycleDependOnParentSkill: false)
		{
		}
	}
}
