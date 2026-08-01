namespace Assets.Scripts.Core.Skills
{
	public class ReduceDamagePercentageBuff : Buff
	{
		private float reduction;

		public float Reduction => 0f;

		public ReduceDamagePercentageBuff(BuffTargetModeInfo buffTargetModeInfo, float duration, float successRate, float reduction, bool isLifeCycleDependOnParentSkill)
			: base(default(BuffType), null, 0f, 0f, isLifeCycleDependOnParentSkill: false)
		{
		}
	}
}
