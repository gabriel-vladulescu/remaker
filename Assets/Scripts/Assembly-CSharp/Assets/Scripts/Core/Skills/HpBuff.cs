namespace Assets.Scripts.Core.Skills
{
	public class HpBuff : Buff
	{
		private float interval;

		private float percent;

		public float Interval => 0f;

		public float Percent => 0f;

		public HpBuff(BuffTargetModeInfo buffTargetModeInfo, float duration, float successRate, float interval, float percent, bool isLifeCycleDependOnParentSkill)
			: base(default(BuffType), null, 0f, 0f, isLifeCycleDependOnParentSkill: false)
		{
		}

		public void SetPercent(float percent)
		{
		}
	}
}
