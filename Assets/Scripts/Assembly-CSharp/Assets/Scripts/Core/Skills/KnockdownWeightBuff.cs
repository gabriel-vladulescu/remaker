namespace Assets.Scripts.Core.Skills
{
	public class KnockdownWeightBuff : Buff
	{
		private float weight;

		public float Weight => 0f;

		public KnockdownWeightBuff(BuffTargetModeInfo buffTargetModeInfo, float duration, float successRate, float weight, bool isLifeCycleDependOnParentSkill)
			: base(default(BuffType), null, 0f, 0f, isLifeCycleDependOnParentSkill: false)
		{
		}
	}
}
