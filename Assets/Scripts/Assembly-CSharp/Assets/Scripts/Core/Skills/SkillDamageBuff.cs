namespace Assets.Scripts.Core.Skills
{
	public class SkillDamageBuff : Buff
	{
		private float bonus;

		public float Bonus
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public SkillDamageBuff(BuffTargetModeInfo buffTargetModeInfo, float duration, float successRate, float bonus, bool isLifeCycleDependOnParentSkill)
			: base(default(BuffType), null, 0f, 0f, isLifeCycleDependOnParentSkill: false)
		{
		}
	}
}
