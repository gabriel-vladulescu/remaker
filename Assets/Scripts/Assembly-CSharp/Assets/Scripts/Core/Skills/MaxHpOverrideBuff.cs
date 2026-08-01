namespace Assets.Scripts.Core.Skills
{
	public class MaxHpOverrideBuff : Buff
	{
		private float percentage;

		public float Percentage => 0f;

		public MaxHpOverrideBuff(BuffTargetModeInfo buffTargetModeInfo, float duration, float successRate, float percentage, bool isLifeCycleDependOnParentSkill)
			: base(default(BuffType), null, 0f, 0f, isLifeCycleDependOnParentSkill: false)
		{
		}
	}
}
