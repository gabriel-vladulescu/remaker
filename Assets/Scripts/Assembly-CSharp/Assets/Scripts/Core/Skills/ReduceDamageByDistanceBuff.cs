namespace Assets.Scripts.Core.Skills
{
	public class ReduceDamageByDistanceBuff : Buff
	{
		private float distance;

		private float from;

		private float to;

		public float Distance => 0f;

		public float From => 0f;

		public float To => 0f;

		public ReduceDamageByDistanceBuff(BuffTargetModeInfo buffTargetModeInfo, float duration, float successRate, float distance, float from, float to, bool isLifeCycleDependOnParentSkill)
			: base(default(BuffType), null, 0f, 0f, isLifeCycleDependOnParentSkill: false)
		{
		}
	}
}
