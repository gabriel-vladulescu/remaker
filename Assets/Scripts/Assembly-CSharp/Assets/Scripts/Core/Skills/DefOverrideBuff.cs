namespace Assets.Scripts.Core.Skills
{
	public class DefOverrideBuff : Buff
	{
		private float percentage;

		public float Percentage => 0f;

		public DefOverrideBuff(BuffTargetModeInfo buffTargetModeInfo, float duration, float successRate, float percentage, bool isLifeCycleDependOnParentSkill)
			: base(default(BuffType), null, 0f, 0f, isLifeCycleDependOnParentSkill: false)
		{
		}
	}
}
