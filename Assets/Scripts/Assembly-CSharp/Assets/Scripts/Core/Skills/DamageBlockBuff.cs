namespace Assets.Scripts.Core.Skills
{
	public class DamageBlockBuff : Buff
	{
		private int blockCount;

		private float percentage;

		public int BlockCount => 0;

		public float Percentage => 0f;

		public DamageBlockBuff(BuffTargetModeInfo buffTargetModeInfo, float duration, float successRate, int blockCount, float percentage, bool isLifeCycleDependOnParentSkill)
			: base(default(BuffType), null, 0f, 0f, isLifeCycleDependOnParentSkill: false)
		{
		}
	}
}
